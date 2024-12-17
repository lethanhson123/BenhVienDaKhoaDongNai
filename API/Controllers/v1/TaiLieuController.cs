namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class TaiLieuController : BaseController<TaiLieu, ITaiLieuService>
    {
    private readonly ITaiLieuService _TaiLieuService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public TaiLieuController(ITaiLieuService TaiLieuService, IWebHostEnvironment WebHostEnvironment) : base(TaiLieuService, WebHostEnvironment)
    {
    _TaiLieuService = TaiLieuService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

