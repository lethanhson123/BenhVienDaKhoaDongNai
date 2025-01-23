namespace API_eHospital_DongNai_A_System.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_GroupCommandsController : BaseController<Sys_GroupCommands, ISys_GroupCommandsService>
    {
        private readonly ISys_GroupCommandsService _Sys_GroupCommandsService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_GroupCommandsController(ISys_GroupCommandsService Sys_GroupCommandsService, IWebHostEnvironment WebHostEnvironment) : base(Sys_GroupCommandsService, WebHostEnvironment)
        {
            _Sys_GroupCommandsService = Sys_GroupCommandsService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByGroup_IdAndEmptyToListAsync")]
        public virtual async Task<List<Sys_GroupCommands>> GetByGroup_IdAndEmptyToListAsync()
        {
            List<Sys_GroupCommands> result = new List<Sys_GroupCommands>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_GroupCommandsService.GetByGroup_IdAndEmptyToListAsync(baseParameter.Group_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

