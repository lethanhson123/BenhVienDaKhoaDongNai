namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Duoc_SoLoNhap_GiaBan_Delete20230518Controller : BaseController<Duoc_SoLoNhap_GiaBan_Delete20230518, IDuoc_SoLoNhap_GiaBan_Delete20230518Service>
    {
    private readonly IDuoc_SoLoNhap_GiaBan_Delete20230518Service _Duoc_SoLoNhap_GiaBan_Delete20230518Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Duoc_SoLoNhap_GiaBan_Delete20230518Controller(IDuoc_SoLoNhap_GiaBan_Delete20230518Service Duoc_SoLoNhap_GiaBan_Delete20230518Service, IWebHostEnvironment WebHostEnvironment) : base(Duoc_SoLoNhap_GiaBan_Delete20230518Service, WebHostEnvironment)
    {
    _Duoc_SoLoNhap_GiaBan_Delete20230518Service = Duoc_SoLoNhap_GiaBan_Delete20230518Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

