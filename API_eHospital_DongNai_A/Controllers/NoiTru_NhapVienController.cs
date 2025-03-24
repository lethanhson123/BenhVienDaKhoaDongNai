namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NoiTru_NhapVienController : BaseController<NoiTru_NhapVien, INoiTru_NhapVienService>
    {
        private readonly INoiTru_NhapVienService _NoiTru_NhapVienService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public NoiTru_NhapVienController(INoiTru_NhapVienService NoiTru_NhapVienService, IWebHostEnvironment WebHostEnvironment) : base(NoiTru_NhapVienService, WebHostEnvironment)
        {
            _NoiTru_NhapVienService = NoiTru_NhapVienService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<NoiTru_NhapVien>> GetByListIDToListAsync()
        {
            List<NoiTru_NhapVien> result = new List<NoiTru_NhapVien>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NoiTru_NhapVienService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

