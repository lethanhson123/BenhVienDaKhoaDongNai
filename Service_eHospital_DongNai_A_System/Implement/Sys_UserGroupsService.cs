namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_UserGroupsService : BaseService<Sys_UserGroups, ISys_UserGroupsRepository>
    , ISys_UserGroupsService
    {
        private readonly ISys_UserGroupsRepository _Sys_UserGroupsRepository;
        public Sys_UserGroupsService(ISys_UserGroupsRepository Sys_UserGroupsRepository) : base(Sys_UserGroupsRepository)
        {
            _Sys_UserGroupsRepository = Sys_UserGroupsRepository;
        }
        public virtual async Task<List<Sys_UserGroups>> GetByUser_IdToListAsync(int User_Id)
        {
            List<Sys_UserGroups> result = new List<Sys_UserGroups>();
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
                result = new List<Sys_UserGroups>();
            }
            return result;
        }
        public virtual async Task<List<Sys_UserGroups>> GetByUser_IdAndEmptyToListAsync(int User_Id)
        {
            List<Sys_UserGroups> result = new List<Sys_UserGroups>();
            Sys_UserGroups empty = new Sys_UserGroups();
            result.Add(empty);
            List<Sys_UserGroups> list = await GetByUser_IdToListAsync(User_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

