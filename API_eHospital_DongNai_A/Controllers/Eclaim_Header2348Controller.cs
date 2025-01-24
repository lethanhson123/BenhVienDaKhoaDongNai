namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Eclaim_Header2348Controller : BaseController<Eclaim_Header2348, IEclaim_Header2348Service>
    {
    private readonly IEclaim_Header2348Service _Eclaim_Header2348Service;
    private readonly IWebHostEnvironment _WebHostEnvironment;
    public Eclaim_Header2348Controller(IEclaim_Header2348Service Eclaim_Header2348Service, IWebHostEnvironment WebHostEnvironment) : base(Eclaim_Header2348Service, WebHostEnvironment)
    {
    _Eclaim_Header2348Service = Eclaim_Header2348Service;
    _WebHostEnvironment = WebHostEnvironment;
    }
    }
    }

