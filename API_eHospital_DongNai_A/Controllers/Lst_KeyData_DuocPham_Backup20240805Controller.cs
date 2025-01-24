namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_KeyData_DuocPham_Backup20240805Controller : BaseController<Lst_KeyData_DuocPham_Backup20240805, ILst_KeyData_DuocPham_Backup20240805Service>
    {
    private readonly ILst_KeyData_DuocPham_Backup20240805Service _Lst_KeyData_DuocPham_Backup20240805Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Lst_KeyData_DuocPham_Backup20240805Controller(ILst_KeyData_DuocPham_Backup20240805Service Lst_KeyData_DuocPham_Backup20240805Service, IWebHostEnvironment WebHostEnvironment) : base(Lst_KeyData_DuocPham_Backup20240805Service, WebHostEnvironment)
    {
    _Lst_KeyData_DuocPham_Backup20240805Service = Lst_KeyData_DuocPham_Backup20240805Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

