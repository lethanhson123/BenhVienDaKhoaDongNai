namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_UserPasswordHistoryService : BaseService<Sys_UserPasswordHistory, ISys_UserPasswordHistoryRepository>
    , ISys_UserPasswordHistoryService
    {
        private readonly ISys_UserPasswordHistoryRepository _Sys_UserPasswordHistoryRepository;
        public Sys_UserPasswordHistoryService(ISys_UserPasswordHistoryRepository Sys_UserPasswordHistoryRepository) : base(Sys_UserPasswordHistoryRepository)
        {
            _Sys_UserPasswordHistoryRepository = Sys_UserPasswordHistoryRepository;
        }
        public virtual async Task<List<Sys_UserPasswordHistory>> GetByUser_IdToListAsync(int User_Id)
        {
            List<Sys_UserPasswordHistory> result = new List<Sys_UserPasswordHistory>();
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
                result = new List<Sys_UserPasswordHistory>();
            }
            return result;
        }
        public virtual async Task<List<Sys_UserPasswordHistory>> GetByUser_IdAndEmptyToListAsync(int User_Id)
        {
            List<Sys_UserPasswordHistory> result = new List<Sys_UserPasswordHistory>();
            Sys_UserPasswordHistory empty = new Sys_UserPasswordHistory();
            result.Add(empty);
            List<Sys_UserPasswordHistory> list = await GetByUser_IdToListAsync(User_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

