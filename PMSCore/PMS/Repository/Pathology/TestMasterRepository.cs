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
            if (model.Action == "I" || model.Action == "U")
            {
                TestMasterValidation(model);
            }
            if (model.MessageId == 0)
            {
                DataSet ds = await _testMasterDAL.TestMasterOperations(model);
                if (model.Action == "I")
                {
                    model.MessageId = 0;
                    model.MessageText = Resources.ValidationMessage.Save;
                }
                else if (model.Action == "U")
                {
                    model.MessageId = 0;
                    model.MessageText = Resources.ValidationMessage.Update;
                }
                else if (model.Action == "D")
                {
                    model.MessageId = 0;
                    model.MessageText = Resources.ValidationMessage.Delete;
                }
            }
        }
        private void TestMasterValidation(TestMasterModel model)
        {
            if (model.Department_Id == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Department;
            }
            else if (model.TestHead_Id == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.TestHead;
            }
            else if (string.IsNullOrEmpty(model.TestName) || string.IsNullOrWhiteSpace(model.TestName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.TestName;
            }
            else if (string.IsNullOrEmpty(model.TestRate) || string.IsNullOrWhiteSpace(model.TestRate))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.TestRate;
            }
        }
    }
}
