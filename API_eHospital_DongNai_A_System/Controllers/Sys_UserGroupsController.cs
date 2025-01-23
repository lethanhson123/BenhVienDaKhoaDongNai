namespace API_eHospital_DongNai_A_System.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_UserGroupsController : BaseController<Sys_UserGroups, ISys_UserGroupsService>
    {
        private readonly ISys_UserGroupsService _Sys_UserGroupsService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_UserGroupsController(ISys_UserGroupsService Sys_UserGroupsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_UserGroupsService, WebHostEnvironment)
        {
            _Sys_UserGroupsService = Sys_UserGroupsService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByUser_IdToListAsync")]
        public virtual async Task<List<Sys_UserGroups>> GetByUser_IdToListAsync()
        {
            List<Sys_UserGroups> result = new List<Sys_UserGroups>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserGroupsService.GetByUser_IdToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_IdAndEmptyToListAsync")]
        public virtual async Task<List<Sys_UserGroups>> GetByUser_IdAndEmptyToListAsync()
        {
            List<Sys_UserGroups> result = new List<Sys_UserGroups>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserGroupsService.GetByUser_IdAndEmptyToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

