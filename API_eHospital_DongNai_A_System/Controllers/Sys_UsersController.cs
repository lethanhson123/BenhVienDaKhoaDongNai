namespace API_eHospital_DongNai_A_System.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Sys_UsersController : BaseController<Sys_Users, ISys_UsersService>
    {
        private readonly ISys_UsersService _Sys_UsersService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_UsersController(ISys_UsersService Sys_UsersService, IWebHostEnvironment WebHostEnvironment) : base(Sys_UsersService, WebHostEnvironment)
        {
            _Sys_UsersService = Sys_UsersService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByUser_IdAsync")]
        public virtual async Task<Sys_Users> GetByUser_IdAsync()
        {
            Sys_Users result = new Sys_Users();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Sys_UsersService.GetByUser_IdAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

