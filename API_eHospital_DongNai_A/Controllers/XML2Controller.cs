namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML2_Controller : BaseController<XML2, IXML2Service>
    {
        private readonly IXML2Service _XML2Service;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public XML2_Controller(IXML2Service XML2Service, IWebHostEnvironment WebHostEnvironment) : base(XML2Service, WebHostEnvironment)
        {
            _XML2Service = XML2Service;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

