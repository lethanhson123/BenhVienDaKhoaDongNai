namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataController : BaseController<BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_Data, IBCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService>
    {
    private readonly IBCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService _BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataController(IBCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService, IWebHostEnvironment WebHostEnvironment) : base(BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService, WebHostEnvironment)
    {
    _BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService = BCSYT_004_TinhHinhBenhTatTuVong_Bieu11_DataService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

