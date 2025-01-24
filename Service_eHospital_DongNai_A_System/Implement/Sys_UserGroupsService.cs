namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_UserGroupsService : BaseService<Sys_UserGroups, ISys_UserGroupsRepository>
    , ISys_UserGroupsService
    {
        private readonly ISys_UserGroupsRepository _Sys_UserGroupsRepository;

        private readonly ISys_GroupsRepository _Sys_GroupsRepository;
        public Sys_UserGroupsService(ISys_UserGroupsRepository Sys_UserGroupsRepository
            , ISys_GroupsRepository sys_GroupsRepository

           ) : base(Sys_UserGroupsRepository)
        {
            _Sys_UserGroupsRepository = Sys_UserGroupsRepository;
            _Sys_GroupsRepository = sys_GroupsRepository;
        }
        public virtual async Task<List<Sys_UserGroups>> GetByUser_Id_SearchStringToListAsync(int User_Id, string searchString)
        {
            List<Sys_UserGroups> result = new List<Sys_UserGroups>();
            if (User_Id > 0)
            {
                result = await GetByCondition(item => item.User_Id == User_Id).ToListAsync();
                if (!string.IsNullOrEmpty(searchString))
                {
                    List<Sys_Groups> ListSys_Groups = await _Sys_GroupsRepository.GetByCondition(item => item.Group_Name.Contains(searchString) || item.Group_Code.Contains(searchString)).ToListAsync();
                    if (ListSys_Groups == null)
                    {
                        ListSys_Groups = new List<Sys_Groups>();
                    }
                    List<int> ListSys_GroupsID = ListSys_Groups.Select(item => item.Group_Id.Value).ToList();
                    if (ListSys_GroupsID.Count > 0)
                    {
                        result = result.Where(item => ListSys_GroupsID.Contains(item.Group_Id.Value)).ToList();
                    }
                }
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
        public virtual async Task<List<Sys_UserGroups>> GetByUser_Id_SearchStringAndEmptyToListAsync(int User_Id, string searchString)
        {
            List<Sys_UserGroups> result = new List<Sys_UserGroups>();
            Sys_UserGroups empty = new Sys_UserGroups();
            result.Add(empty);
            List<Sys_UserGroups> list = await GetByUser_Id_SearchStringToListAsync(User_Id, searchString);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
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

