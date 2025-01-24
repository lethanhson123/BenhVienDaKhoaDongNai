namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML_CheckIn_CV130Controller : BaseController<XML_CheckIn_CV130, IXML_CheckIn_CV130Service>
    {
    private readonly IXML_CheckIn_CV130Service _XML_CheckIn_CV130Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public XML_CheckIn_CV130Controller(IXML_CheckIn_CV130Service XML_CheckIn_CV130Service, IWebHostEnvironment WebHostEnvironment) : base(XML_CheckIn_CV130Service, WebHostEnvironment)
    {
    _XML_CheckIn_CV130Service = XML_CheckIn_CV130Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

