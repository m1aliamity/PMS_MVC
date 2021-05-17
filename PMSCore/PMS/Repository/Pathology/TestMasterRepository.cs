using Models.Pathology;
using PMS.Repository.Pathology.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Pathology.Interface;
using System.Data;

namespace PMS.Repository.Pathology
{
    public class TestMasterRepository : ITestMasterRepository
    {
        private readonly ICommonRepository _commonRepository;
        private readonly ITestMasterDAL _testMasterDAL;
        public TestMasterRepository(ITestMasterDAL testMasterDAL, ICommonRepository commonRepository)
        {
            _testMasterDAL = testMasterDAL;
            _commonRepository = commonRepository;
        }
        public async Task GetMasterData(TestMasterModel model)
        {
            CommonModel commonModel = new CommonModel();
            string masterId = (int)Keys.MasterData.PathologyDepartment + "|";
            await _commonRepository.GetMasterData(commonModel, masterId);
            model.PathologyDepartmentList = commonModel.PathologyDepartmentList;
        }
        public async Task TestMasterOperations(TestMasterModel model)
        {
            CommonModel commonModel = new CommonModel();
            //string masterId = (int)Keys.MasterData.PathologyDepartment + "|" + (int)Keys.MasterData.MritalStatus + "|" + (int)Keys.MasterData.NamePrefix + "|" + (int)Keys.MasterData.Relation + "|" + (int)Keys.MasterData.Religion + "|" + (int)Keys.MasterData.EmployeeType + "|";
            string masterId = (int)Keys.MasterData.PathologyDepartment + "|";
            await _commonRepository.GetMasterData(commonModel, masterId);
            model.PathologyDepartmentList = commonModel.PathologyDepartmentList;
        }
    }
}
