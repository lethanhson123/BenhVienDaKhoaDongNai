namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CUS_ProductsController : BaseController<CUS_Products, ICUS_ProductsService>
    {
    private readonly ICUS_ProductsService _CUS_ProductsService;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public CUS_ProductsController(ICUS_ProductsService CUS_ProductsService, IWebHostEnvironment WebHostEnvironment) : base(CUS_ProductsService, WebHostEnvironment)
    {
    _CUS_ProductsService = CUS_ProductsService;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

