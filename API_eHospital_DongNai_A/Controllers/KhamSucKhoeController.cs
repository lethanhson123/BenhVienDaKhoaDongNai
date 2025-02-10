namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamSucKhoeController : BaseController<KhamSucKhoe, IKhamSucKhoeService>
    {
        private readonly IKhamSucKhoeService _KhamSucKhoeService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public KhamSucKhoeController(IKhamSucKhoeService KhamSucKhoeService, IWebHostEnvironment WebHostEnvironment) : base(KhamSucKhoeService, WebHostEnvironment)
        {
            _KhamSucKhoeService = KhamSucKhoeService;
            _WebHostEnvironment = WebHostEnvironment;
        }
    }
}

