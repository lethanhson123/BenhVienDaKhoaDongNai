namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML1Controller : BaseController<XML1, IXML1Service>
    {
        private readonly IXML1Service _XML1Service;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public XML1Controller(IXML1Service XML1Service, IWebHostEnvironment WebHostEnvironment) : base(XML1Service, WebHostEnvironment)
        {
            _XML1Service = XML1Service;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

