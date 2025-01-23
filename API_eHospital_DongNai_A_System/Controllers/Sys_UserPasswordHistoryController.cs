namespace API_eHospital_DongNai_A_System.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_UserPasswordHistoryController : BaseController<Sys_UserPasswordHistory, ISys_UserPasswordHistoryService>
    {
        private readonly ISys_UserPasswordHistoryService _Sys_UserPasswordHistoryService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_UserPasswordHistoryController(ISys_UserPasswordHistoryService Sys_UserPasswordHistoryService, IWebHostEnvironment WebHostEnvironment) : base(Sys_UserPasswordHistoryService, WebHostEnvironment)
        {
            _Sys_UserPasswordHistoryService = Sys_UserPasswordHistoryService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByUser_IdToListAsync")]
        public virtual async Task<List<Sys_UserPasswordHistory>> GetByUser_IdToListAsync()
        {
            List<Sys_UserPasswordHistory> result = new List<Sys_UserPasswordHistory>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserPasswordHistoryService.GetByUser_IdToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_IdAndEmptyToListAsync")]
        public virtual async Task<List<Sys_UserPasswordHistory>> GetByUser_IdAndEmptyToListAsync()
        {
            List<Sys_UserPasswordHistory> result = new List<Sys_UserPasswordHistory>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserPasswordHistoryService.GetByUser_IdAndEmptyToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

