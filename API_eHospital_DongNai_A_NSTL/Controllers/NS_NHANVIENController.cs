namespace API_eHospital_DongNai_A_NSTL.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NS_NHANVIENController : BaseController<NS_NHANVIEN, INS_NHANVIENService>
    {
        private readonly INS_NHANVIENService _NS_NHANVIENService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public NS_NHANVIENController(INS_NHANVIENService NS_NHANVIENService, IWebHostEnvironment WebHostEnvironment) : base(NS_NHANVIENService, WebHostEnvironment)
        {
            _NS_NHANVIENService = NS_NHANVIENService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByNhanVien_IdAsync")]
        public virtual async Task<NS_NHANVIEN> GetByNhanVien_IdAsync()
        {
            NS_NHANVIEN result = new NS_NHANVIEN();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NS_NHANVIENService.GetByNhanVien_IdAsync(baseParameter.NhanVien_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByMaNhanVienAsync")]
        public virtual async Task<NS_NHANVIEN> GetByMaNhanVienAsync()
        {
            NS_NHANVIEN result = new NS_NHANVIEN();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NS_NHANVIENService.GetByMaNhanVienAsync(baseParameter.MaNhanVien);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

