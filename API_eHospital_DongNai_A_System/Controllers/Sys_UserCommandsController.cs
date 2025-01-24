namespace API_eHospital_DongNai_A_System.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_UserCommandsController : BaseController<Sys_UserCommands, ISys_UserCommandsService>
    {
        private readonly ISys_UserCommandsService _Sys_UserCommandsService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_UserCommandsController(ISys_UserCommandsService Sys_UserCommandsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_UserCommandsService, WebHostEnvironment)
        {
            _Sys_UserCommandsService = Sys_UserCommandsService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByUser_Id_SearchStringToListAsync")]
        public virtual async Task<List<Sys_UserCommands>> GetByUser_Id_SearchStringToListAsync()
        {
            List<Sys_UserCommands> result = new List<Sys_UserCommands>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserCommandsService.GetByUser_Id_SearchStringToListAsync(baseParameter.User_Id.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_Id_SearchStringAndEmptyToListAsync")]
        public virtual async Task<List<Sys_UserCommands>> GetByUser_Id_SearchStringAndEmptyToListAsync()
        {
            List<Sys_UserCommands> result = new List<Sys_UserCommands>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserCommandsService.GetByUser_Id_SearchStringAndEmptyToListAsync(baseParameter.User_Id.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_IdToListAsync")]
        public virtual async Task<List<Sys_UserCommands>> GetByUser_IdToListAsync()
        {
            List<Sys_UserCommands> result = new List<Sys_UserCommands>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserCommandsService.GetByUser_IdToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_IdAndEmptyToListAsync")]
        public virtual async Task<List<Sys_UserCommands>> GetByUser_IdAndEmptyToListAsync()
        {
            List<Sys_UserCommands> result = new List<Sys_UserCommands>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UserCommandsService.GetByUser_IdAndEmptyToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

