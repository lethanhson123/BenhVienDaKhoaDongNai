namespace API_eHospital_DongNai_A_Config.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_AppPrivateSettingsController : BaseController<Sys_AppPrivateSettings, ISys_AppPrivateSettingsService>
    {
        private readonly ISys_AppPrivateSettingsService _Sys_AppPrivateSettingsService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_AppPrivateSettingsController(ISys_AppPrivateSettingsService Sys_AppPrivateSettingsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_AppPrivateSettingsService, WebHostEnvironment)
        {
            _Sys_AppPrivateSettingsService = Sys_AppPrivateSettingsService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByUser_IdAndEmptyToListAsync")]
        public virtual async Task<List<Sys_AppPrivateSettings>> GetByUser_IdAndEmptyToListAsync()
        {
            List<Sys_AppPrivateSettings> result = new List<Sys_AppPrivateSettings>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_AppPrivateSettingsService.GetByUser_IdAndEmptyToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_IdAndGroup_CodeAndEmptyToListAsync")]
        public virtual async Task<List<Sys_AppPrivateSettings>> GetByUser_IdAndGroup_CodeAndEmptyToListAsync()
        {
            List<Sys_AppPrivateSettings> result = new List<Sys_AppPrivateSettings>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_AppPrivateSettingsService.GetByUser_IdAndGroup_CodeAndEmptyToListAsync(baseParameter.User_Id.Value, baseParameter.Group_Code);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

