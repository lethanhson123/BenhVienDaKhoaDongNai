namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThuPhanUngThuocCoHai_ThuocSuDungDongThoiController : BaseController<ThuPhanUngThuocCoHai_ThuocSuDungDongThoi, IThuPhanUngThuocCoHai_ThuocSuDungDongThoiService>
    {
    private readonly IThuPhanUngThuocCoHai_ThuocSuDungDongThoiService _ThuPhanUngThuocCoHai_ThuocSuDungDongThoiService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThuPhanUngThuocCoHai_ThuocSuDungDongThoiController(IThuPhanUngThuocCoHai_ThuocSuDungDongThoiService ThuPhanUngThuocCoHai_ThuocSuDungDongThoiService, IWebHostEnvironment WebHostEnvironment) : base(ThuPhanUngThuocCoHai_ThuocSuDungDongThoiService, WebHostEnvironment)
    {
    _ThuPhanUngThuocCoHai_ThuocSuDungDongThoiService = ThuPhanUngThuocCoHai_ThuocSuDungDongThoiService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

