namespace API_eHospital_DongNai_A_System.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_GroupMenusController : BaseController<Sys_GroupMenus, ISys_GroupMenusService>
    {
        private readonly ISys_GroupMenusService _Sys_GroupMenusService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_GroupMenusController(ISys_GroupMenusService Sys_GroupMenusService, IWebHostEnvironment WebHostEnvironment) : base(Sys_GroupMenusService, WebHostEnvironment)
        {
            _Sys_GroupMenusService = Sys_GroupMenusService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByGroup_IdAndEmptyToListAsync")]
        public virtual async Task<List<Sys_GroupMenus>> GetByGroup_IdAndEmptyToListAsync()
        {
            List<Sys_GroupMenus> result = new List<Sys_GroupMenus>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_GroupMenusService.GetByGroup_IdAndEmptyToListAsync(baseParameter.Group_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

