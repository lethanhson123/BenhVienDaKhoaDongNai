namespace API_eHospital_DongNai_A_System.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_MenusController : BaseController<Sys_Menus, ISys_MenusService>
    {
        private readonly ISys_MenusService _Sys_MenusService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_MenusController(ISys_MenusService Sys_MenusService, IWebHostEnvironment WebHostEnvironment) : base(Sys_MenusService, WebHostEnvironment)
        {
            _Sys_MenusService = Sys_MenusService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByMenu_LevelToListAsync")]
        public virtual async Task<List<Sys_Menus>> GetByMenu_LevelToListAsync()
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_MenusService.GetByMenu_LevelToListAsync(baseParameter.Menu_Level.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByParent_IdToListAsync")]
        public virtual async Task<List<Sys_Menus>> GetByParent_IdToListAsync()
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_MenusService.GetByParent_IdToListAsync(baseParameter.Parent_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByParent_IdAndEmptyToListAsync")]
        public virtual async Task<List<Sys_Menus>> GetByParent_IdAndEmptyToListAsync()
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_MenusService.GetByParent_IdAndEmptyToListAsync(baseParameter.Parent_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetBySearchString_Menu_IdToListAsync")]
        public virtual async Task<List<Sys_Menus>> GetBySearchString_Menu_IdToListAsync()
        {
            List<Sys_Menus> result = new List<Sys_Menus>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_MenusService.GetBySearchString_Menu_IdToListAsync(baseParameter.SearchString, baseParameter.Menu_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

