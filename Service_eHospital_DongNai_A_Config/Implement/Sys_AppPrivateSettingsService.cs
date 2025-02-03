namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_AppPrivateSettingsService : BaseService<Sys_AppPrivateSettings, ISys_AppPrivateSettingsRepository>
    , ISys_AppPrivateSettingsService
    {
        private readonly ISys_AppPrivateSettingsRepository _Sys_AppPrivateSettingsRepository;
        public Sys_AppPrivateSettingsService(ISys_AppPrivateSettingsRepository Sys_AppPrivateSettingsRepository) : base(Sys_AppPrivateSettingsRepository)
        {
            _Sys_AppPrivateSettingsRepository = Sys_AppPrivateSettingsRepository;
        }
        public virtual async Task<List<Sys_AppPrivateSettings>> GetByUser_IdToListAsync(int User_Id)
        {
            List<Sys_AppPrivateSettings> result = new List<Sys_AppPrivateSettings>();
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
                result = new List<Sys_AppPrivateSettings>();
            }
            return result;
        }
        public virtual async Task<List<Sys_AppPrivateSettings>> GetByUser_IdAndCodeToListAsync(int User_Id, string Code)
        {
            List<Sys_AppPrivateSettings> result = new List<Sys_AppPrivateSettings>();
            if (User_Id > 0)
            {
                result = await GetByCondition(item => item.User_Id == User_Id && item.Code == Code).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_AppPrivateSettings>();
            }
            return result;
        }
        public virtual async Task<List<Sys_AppPrivateSettings>> GetByUser_IdAndEmptyToListAsync(int User_Id)
        {
            List<Sys_AppPrivateSettings> result = new List<Sys_AppPrivateSettings>();
            Sys_AppPrivateSettings empty = new Sys_AppPrivateSettings();
            result.Add(empty);
            List<Sys_AppPrivateSettings> list = await GetByUser_IdToListAsync(User_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
        public virtual async Task<List<Sys_AppPrivateSettings>> GetByUser_IdAndCodeAndEmptyToListAsync(int User_Id, string Code)
        {
            List<Sys_AppPrivateSettings> result = new List<Sys_AppPrivateSettings>();
            Sys_AppPrivateSettings empty = new Sys_AppPrivateSettings();
            result.Add(empty);
            List<Sys_AppPrivateSettings> list = await GetByUser_IdAndCodeToListAsync(User_Id, Code);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

