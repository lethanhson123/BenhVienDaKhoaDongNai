namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_DM_CHUCDANH_Controller : BaseController<NS_DM_CHUCDANH_, INS_DM_CHUCDANH_Service>
    {
    private readonly INS_DM_CHUCDANH_Service _NS_DM_CHUCDANH_Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public NS_DM_CHUCDANH_Controller(INS_DM_CHUCDANH_Service NS_DM_CHUCDANH_Service, IWebHostEnvironment WebHostEnvironment) : base(NS_DM_CHUCDANH_Service, WebHostEnvironment)
    {
    _NS_DM_CHUCDANH_Service = NS_DM_CHUCDANH_Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

