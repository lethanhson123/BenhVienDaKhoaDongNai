namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_VaoVien_SanKhoaController : BaseController<KhamBenh_VaoVien_SanKhoa, IKhamBenh_VaoVien_SanKhoaService>
    {
        private readonly IKhamBenh_VaoVien_SanKhoaService _KhamBenh_VaoVien_SanKhoaService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public KhamBenh_VaoVien_SanKhoaController(IKhamBenh_VaoVien_SanKhoaService KhamBenh_VaoVien_SanKhoaService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_VaoVien_SanKhoaService, WebHostEnvironment)
        {
            _KhamBenh_VaoVien_SanKhoaService = KhamBenh_VaoVien_SanKhoaService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<KhamBenh_VaoVien_SanKhoa>> GetByListIDToListAsync()
        {
            List<KhamBenh_VaoVien_SanKhoa> result = new List<KhamBenh_VaoVien_SanKhoa>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenh_VaoVien_SanKhoaService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

