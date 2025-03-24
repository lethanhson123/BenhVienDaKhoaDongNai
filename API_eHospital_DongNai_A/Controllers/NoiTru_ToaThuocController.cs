namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_ToaThuocController : BaseController<NoiTru_ToaThuoc, INoiTru_ToaThuocService>
    {
        private readonly INoiTru_ToaThuocService _NoiTru_ToaThuocService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public NoiTru_ToaThuocController(INoiTru_ToaThuocService NoiTru_ToaThuocService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_ToaThuocService, WebHostEnvironment)
        {
            _NoiTru_ToaThuocService = NoiTru_ToaThuocService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<NoiTru_ToaThuoc>> GetByListIDToListAsync()
        {
            List<NoiTru_ToaThuoc> result = new List<NoiTru_ToaThuoc>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NoiTru_ToaThuocService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

