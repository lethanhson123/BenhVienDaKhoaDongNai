namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_MauBenh_ColumnController : BaseController<DM_MauBenh_Column, IDM_MauBenh_ColumnService>
    {
    private readonly IDM_MauBenh_ColumnService _DM_MauBenh_ColumnService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_MauBenh_ColumnController(IDM_MauBenh_ColumnService DM_MauBenh_ColumnService, IWebHostEnvironment WebHostEnvironment) : base(DM_MauBenh_ColumnService, WebHostEnvironment)
    {
    _DM_MauBenh_ColumnService = DM_MauBenh_ColumnService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

