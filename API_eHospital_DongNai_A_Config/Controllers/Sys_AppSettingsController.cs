namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_AppSettingsController : BaseController<Sys_AppSettings, ISys_AppSettingsService>
    {
        private readonly ISys_AppSettingsService _Sys_AppSettingsService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_AppSettingsController(ISys_AppSettingsService Sys_AppSettingsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_AppSettingsService, WebHostEnvironment)
        {
            _Sys_AppSettingsService = Sys_AppSettingsService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("KhoiPhucAsync")]
        public virtual async Task<List<Sys_AppSettings>> KhoiPhucAsync()
        {
            List<Sys_AppSettings> result = new List<Sys_AppSettings>();
            try
            {
                result = await _Sys_AppSettingsService.KhoiPhucAsync();
                foreach (Sys_AppSettings item in result)
                {
                    await _Sys_AppSettingsService.SaveAsync(item);
                    result.Add(item);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

