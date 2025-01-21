namespace Service_eHospital_DongNai_A_System.Interface
{
    public interface ISys_UsersService : IBaseService<Sys_Users>
    {
        Task<Sys_Users> GetByUser_IdAsync(int User_Id);
    }
}

