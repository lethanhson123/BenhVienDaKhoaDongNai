namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_MenusService : BaseService<Sys_Menus, ISys_MenusRepository>
    , ISys_MenusService
    {
        private readonly ISys_MenusRepository _Sys_MenusRepository;
        public Sys_MenusService(ISys_MenusRepository Sys_MenusRepository) : base(Sys_MenusRepository)
        {
            _Sys_MenusRepository = Sys_MenusRepository;
        }
        public virtual async Task<List<Sys_Menus>> GetByMenu_LevelToListAsync(int Menu_Level)
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            if (Menu_Level > 0)
            {
                result = await GetByCondition(item => item.Menu_Level == Menu_Level).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_Menus>();
            }
            return result;
        }
        public virtual async Task<List<Sys_Menus>> GetByParent_IdToListAsync(int Parent_Id)
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            if (Parent_Id > 0)
            {
                result = await GetByCondition(item => item.Parent_Id == Parent_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_Menus>();
            }
            return result;
        }
        public virtual async Task<List<Sys_Menus>> GetByParent_IdAndEmptyToListAsync(int Parent_Id)
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            Sys_Menus empty = new Sys_Menus();
            result.Add(empty);
            List<Sys_Menus> list = await GetByParent_IdToListAsync(Parent_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

