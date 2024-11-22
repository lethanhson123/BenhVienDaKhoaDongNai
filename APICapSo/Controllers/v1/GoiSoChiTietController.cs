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
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietDangKy01ToListAsync")]
        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy01ToListAsync()
        {
            List<DanhMucQuayDichVu> result = new List<DanhMucQuayDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietDangKy01ToListAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietDangKy02ToListAsync")]
        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02ToListAsync()
        {
            List<DanhMucQuayDichVu> result = new List<DanhMucQuayDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietDangKy02ToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietDangKy02_001ToListAsync")]
        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02_001ToListAsync()
        {
            List<DanhMucQuayDichVu> result = new List<DanhMucQuayDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietDangKy02_001ToListAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietDangKy03ToListAsync")]
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy03ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietDangKy03ToListAsync(baseParameter.DanhMucQuayDichVuID.Value, baseParameter.DanhMucDichVuID.Value, baseParameter.Number.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietDangKy04ToListAsync")]
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy04ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietDangKy04ToListAsync(baseParameter.DanhMucQuayDichVuID.Value, baseParameter.Number.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

