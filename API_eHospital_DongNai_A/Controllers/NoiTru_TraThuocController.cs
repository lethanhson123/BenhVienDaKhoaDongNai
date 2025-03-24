namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_TraThuocController : BaseController<NoiTru_TraThuoc, INoiTru_TraThuocService>
    {
        private readonly INoiTru_TraThuocService _NoiTru_TraThuocService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public NoiTru_TraThuocController(INoiTru_TraThuocService NoiTru_TraThuocService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_TraThuocService, WebHostEnvironment)
        {
            _NoiTru_TraThuocService = NoiTru_TraThuocService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<NoiTru_TraThuoc>> GetByListIDToListAsync()
        {
            List<NoiTru_TraThuoc> result = new List<NoiTru_TraThuoc>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NoiTru_TraThuocService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

