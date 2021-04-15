﻿using Models.Pathology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMS.Repository.Pathology.Interface
{
    public interface ICompanyRepository
    {
        Task GetCompany(CompanyModel model);
        Task CompanyOperations(CompanyModel model);
    }
}
