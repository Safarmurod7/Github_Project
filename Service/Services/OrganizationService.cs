﻿using Service.DTOs;
using Service.Helpers;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class OrganizationService : IOrganizationService
    {
        public ValueTask<Response<OrganizationDto>> AddUserAsync(OrganizationDto OrganizationDto)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Response<bool>> DeleteUserAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Response<List<OrganizationDto>>> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Response<OrganizationDto>> GetUserByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Response<OrganizationDto>> ModifyUserAsync(long id, OrganizationDto userForCreationDto)
        {
            throw new NotImplementedException();
        }
    }
}