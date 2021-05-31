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
            commonModel.MID = (int)Keys.MasterData.PathologyDepartment + ","+ (int)Keys.MasterData.TestType + ",";
            await _commonRepository.GetMasterData(commonModel);
            model.PathologyDepartmentList = commonModel.PathologyDepartmentList;
            model.TestTypeMasterList = commonModel.TestTypeList;
        }
        public async Task GetTestHeadMaster(TestMasterModel model)
        {
            CommonModel commonModel = new CommonModel();
            commonModel.Id = model.DepartmentId;
            await _commonRepository.GetTestHeadMaster(commonModel);
            model.TestHeadMasterList = commonModel.TestHeadMasterList;
        }
        public async Task TestMasterOperations(TestMasterModel model)
        {
            DataSet da=await _testMasterDAL.TestMasterOperations(model);
        }
    }
}
