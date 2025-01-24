namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BCTH_015_HoatDongKhamBenh_DataController : BaseController<BCTH_015_HoatDongKhamBenh_Data, IBCTH_015_HoatDongKhamBenh_DataService>
    {
    private readonly IBCTH_015_HoatDongKhamBenh_DataService _BCTH_015_HoatDongKhamBenh_DataService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BCTH_015_HoatDongKhamBenh_DataController(IBCTH_015_HoatDongKhamBenh_DataService BCTH_015_HoatDongKhamBenh_DataService, IWebHostEnvironment WebHostEnvironment) : base(BCTH_015_HoatDongKhamBenh_DataService, WebHostEnvironment)
    {
    _BCTH_015_HoatDongKhamBenh_DataService = BCTH_015_HoatDongKhamBenh_DataService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

