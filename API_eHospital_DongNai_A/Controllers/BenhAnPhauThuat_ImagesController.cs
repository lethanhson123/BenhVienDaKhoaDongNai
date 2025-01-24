namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnPhauThuat_ImagesController : BaseController<BenhAnPhauThuat_Images, IBenhAnPhauThuat_ImagesService>
    {
    private readonly IBenhAnPhauThuat_ImagesService _BenhAnPhauThuat_ImagesService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public BenhAnPhauThuat_ImagesController(IBenhAnPhauThuat_ImagesService BenhAnPhauThuat_ImagesService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnPhauThuat_ImagesService, WebHostEnvironment)
    {
    _BenhAnPhauThuat_ImagesService = BenhAnPhauThuat_ImagesService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

