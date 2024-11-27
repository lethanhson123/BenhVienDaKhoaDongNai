namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhachHangController : BaseController<KhachHang, IKhachHangService>
    {
        private readonly IKhachHangService _KhachHangService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public KhachHangController(IKhachHangService KhachHangService, IWebHostEnvironment WebHostEnvironment) : base(KhachHangService, WebHostEnvironment)
        {
            _KhachHangService = KhachHangService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetBySearchStringToAsync")]
        public virtual async Task<KhachHang> GetBySearchStringToAsync()
        {
            KhachHang result = new KhachHang();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhachHangService.GetBySearchStringToAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByCodeToAsync")]
        public virtual async Task<KhachHang> GetByCodeToAsync()
        {
            KhachHang result = new KhachHang();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhachHangService.GetByCodeToAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByBHYTToAsync")]
        public virtual async Task<KhachHang> GetByBHYTToAsync()
        {
            KhachHang result = new KhachHang();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhachHangService.GetByBHYTToAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByCCCDToAsync")]
        public virtual async Task<KhachHang> GetByCCCDToAsync()
        {
            KhachHang result = new KhachHang();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhachHangService.GetByCCCDToAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByDienThoaiToAsync")]
        public virtual async Task<KhachHang> GetByDienThoaiToAsync()
        {
            KhachHang result = new KhachHang();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhachHangService.GetByDienThoaiToAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

