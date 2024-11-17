﻿using BusinessLogic.IService.IRoleService;
using BusinessLogic.IService.IUserService;

namespace BusinessLogic.IService
{
    public interface IServiceManager
    {
        IUserServices UserService { get; }
        IRoleServices RoleService { get; }
    }
}
