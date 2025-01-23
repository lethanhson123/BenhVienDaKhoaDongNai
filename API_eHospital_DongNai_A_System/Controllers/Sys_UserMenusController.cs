namespace API_eHospital_DongNai_A_System.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_UserMenusController : BaseController<Sys_UserMenus, ISys_UserMenusService>
    {
        private readonly ISys_UserMenusService _Sys_UserMenusService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_UserMenusController(ISys_UserMenusService Sys_UserMenusService, IWebHostEnvironment WebHostEnvironment) : base(Sys_UserMenusService, WebHostEnvironment)
        {
            _Sys_UserMenusService = Sys_UserMenusService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByUser_IdToListAsync")]
        public virtual async Task<List<Sys_UserMenus>> GetByUser_IdToListAsync()
        {
            List<Sys_UserMenus> result = new List<Sys_UserMenus>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserMenusService.GetByUser_IdToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_IdAndEmptyToListAsync")]
        public virtual async Task<List<Sys_UserMenus>> GetByUser_IdAndEmptyToListAsync()
        {
            List<Sys_UserMenus> result = new List<Sys_UserMenus>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserMenusService.GetByUser_IdAndEmptyToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

