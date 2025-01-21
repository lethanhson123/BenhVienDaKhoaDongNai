namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_GroupMenusService : BaseService<Sys_GroupMenus, ISys_GroupMenusRepository>
    , ISys_GroupMenusService
    {
        private readonly ISys_GroupMenusRepository _Sys_GroupMenusRepository;
        public Sys_GroupMenusService(ISys_GroupMenusRepository Sys_GroupMenusRepository) : base(Sys_GroupMenusRepository)
        {
            _Sys_GroupMenusRepository = Sys_GroupMenusRepository;
        }
        public virtual async Task<List<Sys_GroupMenus>> GetByGroup_IdToListAsync(int Group_Id)
        {
            List<Sys_GroupMenus> result = new List<Sys_GroupMenus>();
            if (Group_Id > 0)
            {
                result = await GetByCondition(item => item.Group_Id == Group_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_GroupMenus>();
            }
            return result;
        }
        public virtual async Task<List<Sys_GroupMenus>> GetByGroup_IdAndEmptyToListAsync(int Group_Id)
        {
            List<Sys_GroupMenus> result = new List<Sys_GroupMenus>();
            Sys_GroupMenus empty = new Sys_GroupMenus();
            result.Add(empty);
            List<Sys_GroupMenus> list = await GetByGroup_IdToListAsync(Group_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

