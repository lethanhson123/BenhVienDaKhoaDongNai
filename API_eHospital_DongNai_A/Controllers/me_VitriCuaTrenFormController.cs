namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class me_VitriCuaTrenFormController : BaseController<me_VitriCuaTrenForm, Ime_VitriCuaTrenFormService>
    {
    private readonly Ime_VitriCuaTrenFormService _me_VitriCuaTrenFormService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public me_VitriCuaTrenFormController(Ime_VitriCuaTrenFormService me_VitriCuaTrenFormService, IWebHostEnvironment WebHostEnvironment) : base(me_VitriCuaTrenFormService, WebHostEnvironment)
    {
    _me_VitriCuaTrenFormService = me_VitriCuaTrenFormService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

