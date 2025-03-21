﻿namespace Service_eHospital_DongNai_A_System.Interface
{
    public interface ISys_UserCommandsService : IBaseService<Sys_UserCommands>
    {
        Task<List<Sys_UserCommands>> GetByUser_Id_SearchStringToListAsync(int User_Id, string searchString);
        Task<List<Sys_UserCommands>> GetByUser_Id_SearchStringAndEmptyToListAsync(int User_Id, string searchString);
        Task<List<Sys_UserCommands>> GetByUser_IdToListAsync(int User_Id);
        Task<List<Sys_UserCommands>> GetByUser_IdAndEmptyToListAsync(int User_Id);
    }
}

