namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThongTinKhamSucKhoeController : BaseController<ThongTinKhamSucKhoe, IThongTinKhamSucKhoeService>
    {
    private readonly IThongTinKhamSucKhoeService _ThongTinKhamSucKhoeService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThongTinKhamSucKhoeController(IThongTinKhamSucKhoeService ThongTinKhamSucKhoeService, IWebHostEnvironment WebHostEnvironment) : base(ThongTinKhamSucKhoeService, WebHostEnvironment)
    {
    _ThongTinKhamSucKhoeService = ThongTinKhamSucKhoeService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

