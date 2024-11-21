namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoChiTietController : BaseController<GoiSoChiTiet, IGoiSoChiTietService>
    {
        private readonly IGoiSoChiTietService _GoiSoChiTietService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoChiTietController(IGoiSoChiTietService GoiSoChiTietService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoChiTietService, WebHostEnvironment)
        {
            _GoiSoChiTietService = GoiSoChiTietService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync")]
        public virtual async Task<GoiSoChiTiet> GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync()
        {
            GoiSoChiTiet result = new GoiSoChiTiet();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.NgayCapSoSoThuTu.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
    }
}

