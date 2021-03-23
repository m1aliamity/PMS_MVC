using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace DAL.Connection
{
    public class MySqlHelperClass
    {
        private string _ConnectionString = string.Empty;// ConnectionString.GetConnectionString(); //ConfigurationManager.ConnectionStrings["shanu"].ToString();
        private MySqlConnection connection;
        #region Initiallize  
        public MySqlHelperClass()
        {
            Initialize();
        }
        //Initialize values  
        private void Initialize()
        {
            _ConnectionString = ReadConnectionString();
            connection = new MySqlConnection(_ConnectionString);
        }
        private string ReadConnectionString()
        {
            return _ConnectionString = ConnectionString.GetConnectionString();
        }
        #endregion
        #region DB ConnectionOpen  
        private async Task<bool> OpenConnection()
        {
            try
            {
                await connection.OpenAsync();
                return true;
            }
            catch (MySqlException ex)
            {
                string str = ex.ToString();
                return false;
            }
        }
        #endregion
        #region DB Connection Close  
        //Close connection  
        public async Task<bool> CloseConnection()
        {
            try
            {
                await connection.CloseAsync();
                return true;
            }
            catch (MySqlException ex)
            {
                string str = ex.ToString();
                return false;
            }
        }
        #endregion
        #region ExecuteNonQuery  
        //for insert / Update and Delete
        //For Insert/Update/Delete  
        public async Task<int> ExecuteNonQuery_IUD(string Querys)
        {
            int result = 0;
            //open connection  
            if (await OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor  
                MySqlCommand cmd = new MySqlCommand(Querys, connection);
                //Execute command  
                result = await cmd.ExecuteNonQueryAsync();
                //close connection  
                await CloseConnection();
            }
            return result;
        }
        #endregion  
        #region Dataset  
        //for select result and  
        //return as Dataset
        //for select result and return as Dataset  
        public async Task<DataSet> DataSet_return(string Querys)
        {
            DataSet ds = new DataSet();
            //open connection  
            if (await OpenConnection() == true)
            {
                try
                {
                    //for Select Query   
                    MySqlCommand cmdSel = new MySqlCommand(Querys, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    await da.FillAsync(ds);
                    //close connection  
                    await CloseConnection();
                }
                catch (Exception ex)
                {
                    await CloseConnection();
                }
            }
            return ds;
        }
        #endregion
        #region DataTable  
        // for select result and  
        //return as DataTable
        //for select result and return as DataTable  
        public async Task<DataTable> DataTable_return(string Querys)
        {
          
            DataTable dt = new DataTable();
            //open connection  
            if (await OpenConnection() == true)
            {
                try
                {
                    //for Select Query   
                    MySqlCommand cmdSel = new MySqlCommand(Querys, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    await da.FillAsync(dt);
                    await CloseConnection();
                }
                catch (Exception ex)
                {
                    await CloseConnection();
                }
            //close connection  
            
            }
            return dt;
        }
        #endregion  
        #region Dataset  
        //for Stored Procedure and  
        //return as DataTable
        //for select result and return as DataTable
        public async Task<DataTable> SP_DataTable(string ProcName, params MySqlParameter[] commandParameters)
        {
            DataTable dt = new DataTable();
            //open connection  
            if (await OpenConnection() == true)
            {
                //for Select Query   
                MySqlCommand cmdSel = new MySqlCommand(ProcName, connection);
                cmdSel.CommandType = CommandType.StoredProcedure;
                // Assign the provided values to these parameters based on parameter order  
                AssignParameterValues(commandParameters, commandParameters);
                AttachParameters(cmdSel, commandParameters);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                await da.FillAsync(dt);
                //close connection  
                await CloseConnection();
            }
            return dt;
        }
        public async Task<DataSet> SP_DataSet(string ProcName, params MySqlParameter[] commandParameters)
        {
            DataSet ds = new DataSet();
            //open connection  
            if (await OpenConnection() == true)
            {
                //for Select Query   
                MySqlCommand cmdSel = new MySqlCommand(ProcName, connection);
                cmdSel.CommandType = CommandType.StoredProcedure;
                // Assign the provided values to these parameters based on parameter order  
                AssignParameterValues(commandParameters, commandParameters);
                AttachParameters(cmdSel, commandParameters);
                MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                await da.FillAsync(ds);
                //close connection  
                await CloseConnection();
            }
            return ds;
        }
        private static void AttachParameters(MySqlCommand command, MySqlParameter[] commandParameters)
        {
            if (command == null) throw new ArgumentNullException("command");
            if (commandParameters != null)
            {
                foreach (MySqlParameter p in commandParameters)
                {
                    if (p != null)
                    {
                        // Check for derived output value with no value assigned  
                        if ((p.Direction == ParameterDirection.InputOutput || p.Direction == ParameterDirection.Input) && (p.Value == null))
                        {
                            p.Value = DBNull.Value;
                        }
                        command.Parameters.Add(p);
                    }
                }
            }
        }
        private static void AssignParameterValues(MySqlParameter[] commandParameters, object[] parameterValues)
        {
            if ((commandParameters == null) || (parameterValues == null))
            {
                // Do nothing if we get no data  
                return;
            }
            // We must have the same number of values as we pave parameters to put them in  
            if (commandParameters.Length != parameterValues.Length)
            {
                throw new ArgumentException("Parameter count does not match Parameter Value count.");
            }
            // Iterate through the SqlParameters, assigning the values from the corresponding position in the   
            // value array  
            for (int i = 0, j = commandParameters.Length; i < j; i++)
            {
                // If the current array value derives from IDbDataParameter, then assign its Value property  
                if (parameterValues[i] is IDbDataParameter)
                {
                    IDbDataParameter paramInstance = (IDbDataParameter)parameterValues[i];
                    if (paramInstance.Value == null)
                    {
                        commandParameters[i].Value = DBNull.Value;
                    }
                    else
                    {
                        commandParameters[i].Value = paramInstance.Value;
                    }
                }
                else if (parameterValues[i] == null)
                {
                    commandParameters[i].Value = DBNull.Value;
                }
                else
                {
                    commandParameters[i].Value = parameterValues[i];
                }
            }
        }
        #endregion
    }
}
