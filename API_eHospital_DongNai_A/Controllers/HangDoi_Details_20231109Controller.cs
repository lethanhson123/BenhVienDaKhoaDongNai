namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HangDoi_Details_20231109Controller : BaseController<HangDoi_Details_20231109, IHangDoi_Details_20231109Service>
    {
    private readonly IHangDoi_Details_20231109Service _HangDoi_Details_20231109Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public HangDoi_Details_20231109Controller(IHangDoi_Details_20231109Service HangDoi_Details_20231109Service, IWebHostEnvironment WebHostEnvironment) : base(HangDoi_Details_20231109Service, WebHostEnvironment)
    {
    _HangDoi_Details_20231109Service = HangDoi_Details_20231109Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

