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
        [Route("SaveAsync")]
        public virtual async Task<GoiSoChiTiet> SaveAsync()
        {
            GoiSoChiTiet result = new GoiSoChiTiet();
            try
            {
                result = JsonConvert.DeserializeObject<GoiSoChiTiet>(Request.Form["data"]);
                result = await _GoiSoChiTietService.SaveAsync(result);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("UpdateByDanhMucDichVuID_NgayDangKySoThuTuTu_CodeAsync")]
        public virtual async Task<GoiSoChiTiet> UpdateByDanhMucDichVuID_NgayDangKySoThuTuTu_CodeAsync()
        {
            GoiSoChiTiet result = new GoiSoChiTiet();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.UpdateByDanhMucDichVuID_NgayDangKySoThuTuTu_CodeAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.SoHienTai.Value, baseParameter.Code);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
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
        [Route("GetNgayCapSoSoThuTuStringToAsync")]
        public virtual async Task<GoiSoChiTiet> GetNgayCapSoSoThuTuStringToAsync()
        {
            GoiSoChiTiet result = new GoiSoChiTiet();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetNgayCapSoSoThuTuStringToAsync(baseParameter.NgayCapSoSoThuTuString);
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
        [Route("GetGoiSoChiTietDangKy02_002ToListAsync")]
        public virtual async Task<List<DanhMucQuayDichVu>> GetGoiSoChiTietDangKy02_002ToListAsync()
        {
            List<DanhMucQuayDichVu> result = new List<DanhMucQuayDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietDangKy02_002ToListAsync(baseParameter.SearchString);
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
        [HttpPost]
        [Route("GetGoiSoChiTietDangKy04_001ToListAsync")]
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy04_001ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietDangKy04_001ToListAsync(baseParameter.Code, baseParameter.Number.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietDangKy05ToListAsync")]
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietDangKy05ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietDangKy05ToListAsync(baseParameter.DanhMucPhongKhamID.Value, baseParameter.Number.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietTiepNhan04_001ToListAsync")]
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietTiepNhan04_001ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietTiepNhan04_001ToListAsync(baseParameter.Code, baseParameter.Number.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietTiepNhan05ToListAsync")]
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietTiepNhan05ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietTiepNhan05ToListAsync(baseParameter.GroupOrder.Value, baseParameter.Number.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietTiepNhan06ToListAsync")]
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietTiepNhan06ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietTiepNhan06ToListAsync(baseParameter.DanhMucQuayDichVuID.Value, baseParameter.Number.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetGoiSoChiTietTiepNhan07ToListAsync")]
        public virtual async Task<List<GoiSoChiTiet>> GetGoiSoChiTietTiepNhan07ToListAsync()
        {
            List<GoiSoChiTiet> result = new List<GoiSoChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoChiTietService.GetGoiSoChiTietTiepNhan07ToListAsync(baseParameter.DanhMucQuayDichVuID.Value, baseParameter.Number.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }

    }
}

