namespace Service_eHospital_DongNai_A_System.Interface
{
    public interface ISys_UserPasswordHistoryService : IBaseService<Sys_UserPasswordHistory>
    {
        Task<List<Sys_UserPasswordHistory>> GetByUser_IdToListAsync(int User_Id);
        Task<List<Sys_UserPasswordHistory>> GetByUser_IdAndEmptyToListAsync(int User_Id);
    }
}

