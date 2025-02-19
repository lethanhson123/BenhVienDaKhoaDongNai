namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_AppSettingsService : BaseService<Sys_AppSettings, ISys_AppSettingsRepository>
    , ISys_AppSettingsService
    {
        private readonly ISys_AppSettingsRepository _Sys_AppSettingsRepository;
        public Sys_AppSettingsService(ISys_AppSettingsRepository Sys_AppSettingsRepository) : base(Sys_AppSettingsRepository)
        {
            _Sys_AppSettingsRepository = Sys_AppSettingsRepository;
        }
        public override void Initialization(Sys_AppSettings model)
        {
            BaseInitialization(model);
            if (string.IsNullOrEmpty(model.Language_Id))
            {
                model.Language_Id = "Vi";
            }
            if (model.Locked == null)
            {
                model.Locked = false;
            }
            if (model.SystemEditOnly == null)
            {
                model.SystemEditOnly = true;
            }
        }
        public override async Task<Sys_AppSettings> SaveAsync(Sys_AppSettings model)
        {
            try
            {
                if (model.Setting_Id > 0)
                {
                    await UpdateAsync(model);
                }
                else
                {
                    await AddAsync(model);
                }
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return model;
        }
    }
}

