namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Map_ChuyenKhoaKham_PhongBanController : BaseController<Map_ChuyenKhoaKham_PhongBan, IMap_ChuyenKhoaKham_PhongBanService>
    {
    private readonly IMap_ChuyenKhoaKham_PhongBanService _Map_ChuyenKhoaKham_PhongBanService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Map_ChuyenKhoaKham_PhongBanController(IMap_ChuyenKhoaKham_PhongBanService Map_ChuyenKhoaKham_PhongBanService, IWebHostEnvironment WebHostEnvironment) : base(Map_ChuyenKhoaKham_PhongBanService, WebHostEnvironment)
    {
    _Map_ChuyenKhoaKham_PhongBanService = Map_ChuyenKhoaKham_PhongBanService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

