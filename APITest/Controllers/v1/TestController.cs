namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TestController : BaseController<CongViec, ICongViecService>
    {
        private readonly ICongViecService _CongViecService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public TestController(ICongViecService CongViecService, IWebHostEnvironment WebHostEnvironment) : base(CongViecService, WebHostEnvironment)
        {
            _CongViecService = CongViecService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpGet]
        [Route("Get001Async")]
        public async Task<string> Get001Async()
        {
            string result = GlobalHelper.InitializationString;
            try
            {
                result = "SSSS";
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }              
    }
}

