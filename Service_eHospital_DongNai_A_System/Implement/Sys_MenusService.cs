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
        public override async Task<List<Sys_Menus>> GetBySearchStringToListAsync(string searchString)
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            if (!string.IsNullOrEmpty(searchString))
            {
                result = await GetByCondition(item => item.Menu_Code.Contains(searchString)).ToListAsync();
                if (result == null)
                {
                    result = await GetByCondition(item => item.Menu_Name.Contains(searchString)).ToListAsync();
                }
            }
            else
            {
                result = await GetByCondition(item => 1 == 1).Take(10).ToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_Menus>();
            }
            return result;
        }
        public virtual async Task<List<Sys_Menus>> GetBySearchString_Menu_IdToListAsync(string searchString, int Menu_Id)
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            Sys_Menus Sys_Menus = await GetByCondition(item => item.Menu_Id == Menu_Id).FirstOrDefaultAsync();
            if (Sys_Menus != null)
            {
                result.Add(Sys_Menus);
            }
            result.AddRange(await GetBySearchStringToListAsync(searchString));
            return result;
        }
    }
}

