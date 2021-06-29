﻿using DAL.Pathology.Interface;
using Models.Pathology;
using PMS.Repository.Pathology.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology
{
    public class TestBookingRepository : ITestBookingRepository
    {
        private readonly ICommonRepository _commonRepository;
        private readonly ITestBookingDAL _testBookingDAL;
        public TestBookingRepository(ITestBookingDAL testBookingDAL, ICommonRepository commonRepository)
        {
            _testBookingDAL = testBookingDAL;
            _commonRepository = commonRepository;
        }
        public async Task GetMasterData(TestBookingModel model)
        {
            CommonModel commonModel = new CommonModel();
            commonModel.IsTestBooking = true;
            commonModel.CID = model.CID;
            commonModel.UserId = model.UserId;
            commonModel.MID = (int)Keys.MasterData.PathologyDepartment + "," + (int)Keys.MasterData.Gender + "," + (int)Keys.MasterData.SampleType + "," + (int)Keys.MasterData.NamePrefix + ",";
            if (model.ProfileId == -1)
            {
                commonModel.MID = commonModel.MID + (int)Keys.MasterData.ProfileName + ",";
            }
            await _commonRepository.GetMasterData(commonModel);
            model.DepartmentList = commonModel.PathologyDepartmentList;
            model.GenderList = commonModel.GenderList;
            model.SampleTypeList = commonModel.SampleTypeList;
            model.TitleList = commonModel.NamePrefixList;
            model.ReferredByList = commonModel.ReferredByList;
            model.SampleByList = commonModel.SampleByList;
            model.ProfileMasterList = commonModel.ProfileMasterList;
        }
        public async Task GetTestHeadMaster(TestBookingModel model)
        {
            CommonModel commonModel = new CommonModel();
            commonModel.Id = model.DepartmentId;
            await _commonRepository.GetTestHeadMaster(commonModel);
            model.TestHeadMasterList = commonModel.TestHeadMasterList;
        }
        public async Task GetTest(TestBookingModel model)
        {
            CommonModel commonModel = new CommonModel();
            commonModel.Id = model.HeadId;
            await _commonRepository.GetTestHeadMaster(commonModel);
            model.TestList = commonModel.TestList;
        }
        public async Task AddData(TestBookingModel model)
        {
            DataSet ds = await _testBookingDAL.AddData(model);
            if (Convert.ToInt32(ds.Tables[0].Rows[0]["Flag"]) != 0)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0]["Flag"]) == 1)
                {
                    model.MessageId = 1;
                    model.MessageText = Resources.ValidationMessage.TestAlredyExist;
                }
                else
                {
                    model.MessageId = 1;
                    model.MessageText = Resources.ValidationMessage.ProfileAlredyExist;
                }
            }
            else
            {
                model.TestList = (from DataRow row in ds.Tables[1].Rows
                                  select new TestBookingModel
                                  {
                                      RowId = Convert.ToInt64(row["Id"]),
                                      TestName = Convert.ToString(row["TestName"]),
                                      Rate = Convert.ToDecimal(row["Rate"]),
                                  }).ToList();
                model.TotalAmount = Convert.ToDecimal(ds.Tables[2].Rows[0]["TotalAmount"]);
            }
        }
        public async Task TestBookingOperations(TestBookingModel model)
        {
            if (model.Action == "1" || model.Action == "2")
            {
                PatientValidation(model);
                TestValidation(model);
            }
            if (model.MessageId == 0)
            {
                DataSet ds = await _testBookingDAL.TestBookingOperations(model);
                if (model.Action == "1")
                {
                    model.MessageId = 0;
                    model.MessageText = Resources.ValidationMessage.Save;
                }
                else if (model.Action == "2")
                {
                    model.MessageId = 0;
                    model.MessageText = Resources.ValidationMessage.Update;
                }
                else if (model.Action == "3")
                {
                    model.MessageId = 0;
                    model.MessageText = Resources.ValidationMessage.Delete;
                }
                else
                {
                    //model.TestList = (from DataRow row in ds.Tables[0].Rows
                    //                  select new TestBookingModel
                    //                  {
                    //                      RowId = Convert.ToInt32(row["Id"]),
                    //                      DepartmentName = Convert.ToString(row["DepartmentName"]),
                    //                      TestHeadName = Convert.ToString(row["HeadName"]),
                    //                      TestName = Convert.ToString(row["TestName"]),
                    //                      TestRate = Convert.ToString(row["TestRate"]),
                    //                  }).ToList();
                }
            }
        }
        private void PatientValidation(TestBookingModel model)
        {
            if (model.TitleId == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.SelectTitle;
            }
            else if (string.IsNullOrEmpty(model.PatientName) && string.IsNullOrWhiteSpace(model.PatientName))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.PatientName;
            }
            else if (model.GenderId == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.Gender;
            }
            else if (model.ReferredById == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.ReferredBy;
            }
            else if (model.SampleById == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.SampleBy;
            }
            else if (model.SampleTypeId == 0)
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.SampleType;
            }
        }
        private void TestValidation(TestBookingModel model)
        {
            if (Convert.ToDecimal(model.TotalAmount)== Convert.ToDecimal(0))
            {
                model.MessageId = 1;
                model.MessageText = Resources.ValidationMessage.TotalAmount;
            }
            //else if (Convert.ToDecimal(model.PaidAmount) == Convert.ToDecimal(0))
            //{
            //    model.MessageId = 1;
            //    model.MessageText = Resources.ValidationMessage.Gender;
            //}
        }
       public async Task SearchBookingData(TestBookingModel model)
        {
            DataSet ds = await _testBookingDAL.SearchBookingData(model);
            if (model.Action=="1")
            {
                    model.TestList = (from DataRow row in ds.Tables[0].Rows
                                      select new TestBookingModel
                                      {
                                          RowId = Convert.ToInt64(row["Id"]),
                                          PatientName = Convert.ToString(row["PatientName"]),
                                          PatientAge = Convert.ToString(row["Age"]),
                                          GenderName = Convert.ToString(row["Gender"]),
                                          SampleTypeName = Convert.ToString(row["SampleType"]),
                                          Address = Convert.ToString(row["Address"]),
                                          BookingDate = Convert.ToDateTime(row["BookingDate"]),
                                      }).ToList();
            }
        }
    }
}
