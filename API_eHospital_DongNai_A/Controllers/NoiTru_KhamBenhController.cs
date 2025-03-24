namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_KhamBenhController : BaseController<NoiTru_KhamBenh, INoiTru_KhamBenhService>
    {
        private readonly INoiTru_KhamBenhService _NoiTru_KhamBenhService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public NoiTru_KhamBenhController(INoiTru_KhamBenhService NoiTru_KhamBenhService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_KhamBenhService, WebHostEnvironment)
        {
            _NoiTru_KhamBenhService = NoiTru_KhamBenhService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<NoiTru_KhamBenh>> GetByListIDToListAsync()
        {
            List<NoiTru_KhamBenh> result = new List<NoiTru_KhamBenh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NoiTru_KhamBenhService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

