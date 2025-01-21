namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_UsersService : BaseService<Sys_Users, ISys_UsersRepository>
    , ISys_UsersService
    {
        private readonly ISys_UsersRepository _Sys_UsersRepository;
        public Sys_UsersService(ISys_UsersRepository Sys_UsersRepository) : base(Sys_UsersRepository)
        {
            _Sys_UsersRepository = Sys_UsersRepository;
        }
        public virtual async Task<Sys_Users> GetByUser_IdAsync(int User_Id)
        {
            Sys_Users result = new Sys_Users();
            if (User_Id > 0)
            {
                result = await GetByCondition(item => item.User_Id == User_Id).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new Sys_Users();
            }
            return result;
        }
    }
}

