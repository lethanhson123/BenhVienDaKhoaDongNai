namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_BenhNhan_NotesController : BaseController<DM_BenhNhan_Notes, IDM_BenhNhan_NotesService>
    {
    private readonly IDM_BenhNhan_NotesService _DM_BenhNhan_NotesService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public DM_BenhNhan_NotesController(IDM_BenhNhan_NotesService DM_BenhNhan_NotesService, IWebHostEnvironment WebHostEnvironment) : base(DM_BenhNhan_NotesService, WebHostEnvironment)
    {
    _DM_BenhNhan_NotesService = DM_BenhNhan_NotesService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

