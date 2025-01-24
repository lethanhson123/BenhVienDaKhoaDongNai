namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_MenuListController : BaseController<me_MenuList, Ime_MenuListService>
    {
    private readonly Ime_MenuListService _me_MenuListService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_MenuListController(Ime_MenuListService me_MenuListService, IWebHostEnvironment WebHostEnvironment) : base(me_MenuListService, WebHostEnvironment)
    {
    _me_MenuListService = me_MenuListService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

