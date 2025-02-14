namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_VaoVienController : BaseController<KhamBenh_VaoVien, IKhamBenh_VaoVienService>
    {
        private readonly IKhamBenh_VaoVienService _KhamBenh_VaoVienService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public KhamBenh_VaoVienController(IKhamBenh_VaoVienService KhamBenh_VaoVienService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_VaoVienService, WebHostEnvironment)
        {
            _KhamBenh_VaoVienService = KhamBenh_VaoVienService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByKhamBenhVaoVien_IdAsync")]
        public virtual async Task<KhamBenh_VaoVien> GetByKhamBenhVaoVien_IdAsync()
        {
            KhamBenh_VaoVien result = new KhamBenh_VaoVien();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenh_VaoVienService.GetByKhamBenhVaoVien_IdAsync(baseParameter.KhamBenhVaoVien_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNgayKham_SearchStringToListAsync")]
        public virtual async Task<List<KhamBenh_VaoVien>> GetByNgayKham_SearchStringToListAsync()
        {
            List<KhamBenh_VaoVien> result = new List<KhamBenh_VaoVien>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenh_VaoVienService.GetByNgayKham_SearchStringToListAsync(baseParameter.NgayKham.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByYear_Month_Day_SearchStringToListAsync")]
        public virtual async Task<List<KhamBenh_VaoVien>> GetByYear_Month_Day_SearchStringToListAsync()
        {
            List<KhamBenh_VaoVien> result = new List<KhamBenh_VaoVien>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenh_VaoVienService.GetByYear_Month_Day_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

