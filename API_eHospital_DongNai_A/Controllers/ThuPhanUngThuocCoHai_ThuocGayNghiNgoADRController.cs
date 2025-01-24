namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRController : BaseController<ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR, IThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService>
    {
    private readonly IThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService _ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRController(IThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService, IWebHostEnvironment WebHostEnvironment) : base(ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService, WebHostEnvironment)
    {
    _ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService = ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

