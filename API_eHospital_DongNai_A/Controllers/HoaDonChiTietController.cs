namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class HoaDonChiTietController : BaseController<HoaDonChiTiet, IHoaDonChiTietService>
    {
        private readonly IHoaDonChiTietService _HoaDonChiTietService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public HoaDonChiTietController(IHoaDonChiTietService HoaDonChiTietService, IWebHostEnvironment WebHostEnvironment) : base(HoaDonChiTietService, WebHostEnvironment)
        {
            _HoaDonChiTietService = HoaDonChiTietService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<HoaDonChiTiet>> GetByListIDToListAsync()
        {
            List<HoaDonChiTiet> result = new List<HoaDonChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _HoaDonChiTietService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

