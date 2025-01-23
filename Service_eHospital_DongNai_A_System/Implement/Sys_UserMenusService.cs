namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_UserMenusService : BaseService<Sys_UserMenus, ISys_UserMenusRepository>
    , ISys_UserMenusService
    {
        private readonly ISys_UserMenusRepository _Sys_UserMenusRepository;
        public Sys_UserMenusService(ISys_UserMenusRepository Sys_UserMenusRepository) : base(Sys_UserMenusRepository)
        {
            _Sys_UserMenusRepository = Sys_UserMenusRepository;
        }
        public virtual async Task<List<Sys_UserMenus>> GetByUser_IdToListAsync(int User_Id)
        {
            List<Sys_UserMenus> result = new List<Sys_UserMenus>();
            if (User_Id > 0)
            {
                result = await GetByCondition(item => item.User_Id == User_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_UserMenus>();
            }
            return result;
        }
        public virtual async Task<List<Sys_UserMenus>> GetByUser_IdAndEmptyToListAsync(int User_Id)
        {
            List<Sys_UserMenus> result = new List<Sys_UserMenus>();
            Sys_UserMenus empty = new Sys_UserMenus();
            result.Add(empty);
            List<Sys_UserMenus> list = await GetByUser_IdToListAsync(User_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

