namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML5_Controller : BaseController<XML5, IXML5Service>
    {
        private readonly IXML5Service _XML5Service;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public XML5_Controller(IXML5Service XML5Service, IWebHostEnvironment WebHostEnvironment) : base(XML5Service, WebHostEnvironment)
        {
            _XML5Service = XML5Service;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

