using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Connection
{
    public class MySqlHelperClass2
    {
        //public string mConnStr = string.Empty;// ConnectionString.GetConnectionString(); //ConfigurationManager.ConnectionStrings["shanu"].ToString();
        //public MySqlConnection connection;
        //public MySqlHelperClass2()
        //{
        //    Initialize();
        //}
        ////Initialize values  
        //private void Initialize()
        //{
        //    mConnStr = ReadConnectionString();
        //    connection = new MySqlConnection(mConnStr);
        //}
        //private string ReadConnectionString()
        //{
        //    return mConnStr = ConnectionString.GetConnectionString();
        //}
        ////private static MySQLHelper mInstance = null;

        ////private static String mConnStr = null;

        ///// <summary>  
        ///// Perform additions, deletions, and changes to the SQLite database to return the number of rows affected.  
        ///// </summary>  
        ///// <param name="sql">Addition and deletion of SQL statements to be executed</param>  
        ///// <returns></returns>  
        //public int ExecuteNonQuery(String sql)
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();

        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    PrepareCommand(cmd, connection, transaction, CommandType.Text, sql, null);

        //                    int rows = cmd.ExecuteNonQuery();
        //                    transaction.Commit();

        //                    cmd.Parameters.Clear();
        //                    return rows;
        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        ///// <summary>  
        ///// Perform additions, deletions, and changes to the SQLite database to return the number of rows affected.  
        ///// </summary>  
        ///// <param name="sql">Addition and deletion of SQL statements to be executed</param>  
        ///// <returns></returns>  
        //public int ExecuteNonQuery(String sql, MySqlParameter[] cmdParams)
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();

        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    PrepareCommand(cmd, connection, transaction, CommandType.Text, sql, cmdParams);

        //                    int rows = cmd.ExecuteNonQuery();
        //                    transaction.Commit();

        //                    cmd.Parameters.Clear();
        //                    return rows;
        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ///// <summary>
        //// Perform operations on the SQLite database, return to return the first row of the first row of data
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public int ExecuteScalar(String sql)
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();

        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    int line = 0;

        //                    PrepareCommand(cmd, connection, transaction, CommandType.Text, sql, null);

        //                    String str = cmd.ExecuteScalar().ToString();
        //                    transaction.Commit();

        //                    line = Convert.ToInt32(str);
        //                    cmd.Parameters.Clear();

        //                    return line;
        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ///// <summary>
        //// Perform operations on the SQLite database, return to return the first row of the first row of data
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public int ExecuteScalar(String sql, MySqlParameter[] cmdParams)
        //{
        //    try
        //    {
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();

        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    int line = 0;

        //                    PrepareCommand(cmd, connection, transaction, CommandType.Text, sql, cmdParams);

        //                    String str = cmd.ExecuteScalar().ToString();
        //                    transaction.Commit();

        //                    line = Convert.ToInt32(str);
        //                    cmd.Parameters.Clear();

        //                    return line;
        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ///// <summary>
        ///// Execute a sql command that returns a dataset with the executed database connection
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public MySqlDataReader ExecuteReader(String sql)
        //{
        //    try
        //    {
        //        // Create a MySqlConnection object
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();


        //            // Create a MySqlCommand object
        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    PrepareCommand(cmd, connection, transaction, CommandType.Text, sql, null);

        //                    MySqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        //                    transaction.Commit();

        //                    cmd.Parameters.Clear();
        //                    return reader;
        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ///// <summary>
        ///// The query returns Dtaset
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public DataSet ExecuteDataSet(String sql)
        //{
        //    try
        //    {
        //        // Create a MySqlConnection object
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();


        //            // Create a MySqlCommand object
        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    PrepareCommand(cmd, connection, transaction, CommandType.StoredProcedure, sql, null);

        //                    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //                    adapter.SelectCommand = cmd;
        //                    DataSet ds = new DataSet();

        //                    adapter.Fill(ds);

        //                    transaction.Commit();


        //                    // Clear parameters
        //                    cmd.Parameters.Clear();
        //                    return ds;

        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ///// <summary>
        ///// The query returns Dtaset
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public DataSet ExecuteDataSet(String sql, MySqlParameter[] cmdParams)
        //{
        //    try
        //    {
        //        // Create a MySqlConnection object
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();


        //            // Create a MySqlCommand object
        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    PrepareCommand(cmd, connection, transaction, CommandType.StoredProcedure, sql, cmdParams);

        //                    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //                    adapter.SelectCommand = cmd;
        //                    DataSet ds = new DataSet();

        //                    adapter.Fill(ds);

        //                    transaction.Commit();


        //                    // Clear parameters
        //                    cmd.Parameters.Clear();
        //                    return ds;

        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ///// <summary>
        ///// The query returns a DataTable
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public DataTable ExecuteDataTable(String sql)
        //{
        //    try
        //    {
        //        // Create a MySqlConnection object
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();


        //            // Create a MySqlCommand object
        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    PrepareCommand(cmd, connection, transaction, CommandType.StoredProcedure, sql, null);

        //                    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //                    adapter.SelectCommand = cmd;
        //                    DataTable dt = new DataTable();

        //                    adapter.Fill(dt);

        //                    transaction.Commit();


        //                    // Clear parameters
        //                    cmd.Parameters.Clear();
        //                    return dt;

        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ///// <summary>
        ///// The query returns a DataTable
        ///// </summary>
        ///// <param name="sql"></param>
        ///// <returns></returns>
        //public DataTable ExecuteDataTable(String sql, MySqlParameter[] cmdParams)
        //{
        //    try
        //    {
        //        //Create a MySqlConnection object
        //        using (MySqlConnection connection = new MySqlConnection(mConnStr))
        //        {
        //            connection.Open();
        //            MySqlTransaction transaction = connection.BeginTransaction();


        //            //Create a MySqlCommand object
        //            using (MySqlCommand cmd = new MySqlCommand())
        //            {
        //                try
        //                {
        //                    PrepareCommand(cmd, connection, transaction, CommandType.StoredProcedure, sql, cmdParams);

        //                    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //                    adapter.SelectCommand = cmd;
        //                    DataTable dt = new DataTable();

        //                    adapter.Fill(dt);

        //                    transaction.Commit();


        //                    //Clear parameters
        //                    cmd.Parameters.Clear();
        //                    return dt;

        //                }
        //                catch (MySqlException e1)
        //                {
        //                    try
        //                    {
        //                        transaction.Rollback();
        //                    }
        //                    catch (Exception e2)
        //                    {
        //                        throw e2;
        //                    }

        //                    throw e1;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        ///// <summary>
        ///// Prepare to execute a command
        ///// </summary>
        ///// <param name="cmd">sql command</param>
        ///// <param name="conn">OleDb connection</param>
        ///// <param name="trans">OleDb transaction</param>
        ///// <param name="cmdType">Command type such as stored procedure or text</param>
        ///// <param name="cmdText">Command text, for example: Select * from Products</param>
        ///// <param name="cmdParms">Parameters for executing commands</param>
        //private void PrepareCommand(MySqlCommand cmd, MySqlConnection conn, MySqlTransaction trans, CommandType cmdType, string cmdText, MySqlParameter[] cmdParms)
        //{
        //    if (conn.State != ConnectionState.Open)
        //        conn.Open();

        //    cmd.Connection = conn;
        //    cmd.CommandText = cmdText;

        //    if (trans != null)
        //        cmd.Transaction = trans;

        //    cmd.CommandType = cmdType;
        //    cmd.CommandType = cmdType;

        //    if (cmdParms != null)
        //    {
        //        foreach (MySqlParameter parm in cmdParms)
        //        {
        //            cmd.Parameters.Add(parm);
        //        }
        //    }
        //}
    }
}
