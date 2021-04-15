using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Pathology.Interface
{
    public interface IDoctorDAL
    {
        Task<DataSet> DoctorOperations(DoctorModel model);
    }
}
