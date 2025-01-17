namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class GoiSoController : BaseController<GoiSo, IGoiSoService>
    {
        private readonly IGoiSoService _GoiSoService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoController(IGoiSoService GoiSoService, IWebHostEnvironment WebHostEnvironment) : base(GoiSoService, WebHostEnvironment)
        {
            _GoiSoService = GoiSoService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GoiSoTiepTheoAsync")]
        public virtual async Task<GoiSo> GoiSoTiepTheoAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.GoiSoTiepTheoAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.SoHienTai.Value, baseParameter.DanhMucQuayDichVuID.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("GoiSoTiepTheoByDanhMucDichVuIDAsync")]
        public virtual async Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuIDAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.GoiSoTiepTheoByDanhMucDichVuIDAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.SoHienTai.Value, baseParameter.DanhMucQuayDichVuID.Value, baseParameter.Code);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync")]
        public virtual async Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.DanhMucQuayDichVuID.Value, baseParameter.SoHienTai.Value, baseParameter.Code);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpGet]
        [Route("GetGoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTaiAsync")]
        public virtual async Task<GoiSo> GetGoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTaiAsync(long DanhMucDichVuID, long DanhMucQuayDichVuID, int SoHienTai)
        {
            GoiSo result = new GoiSo();
            try
            {
                result = await _GoiSoService.GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync(DanhMucDichVuID, DanhMucQuayDichVuID, SoHienTai, GlobalHelper.InitializationString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("SaveByDanhMucDichVuIDAsync")]
        public virtual async Task<GoiSo> SaveByDanhMucDichVuIDAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.SaveByDanhMucDichVuIDAsync(baseParameter.DanhMucDichVuID.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("SaveByDanhMucDichVuID_CodeAsync")]
        public virtual async Task<GoiSo> SaveByDanhMucDichVuID_CodeAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.SaveByDanhMucDichVuID_CodeAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.Code);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("SaveByDanhMucDichVuID_Code_DisplayAsync")]
        public virtual async Task<GoiSo> SaveByDanhMucDichVuID_Code_DisplayAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.SaveByDanhMucDichVuID_Code_DisplayAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.Code, baseParameter.Display);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("SaveByDanhMucDichVuID_Code_Display_IsInPhieu_IsGuiZaloAsync")]
        public virtual async Task<GoiSo> SaveByDanhMucDichVuID_Code_Display_IsInPhieu_IsGuiZaloAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.SaveByDanhMucDichVuID_Code_Display_IsInPhieu_IsGuiZaloAsync(baseParameter.DanhMucDichVuID.Value, baseParameter.Code, baseParameter.Display, baseParameter.IsInPhieu.Value, baseParameter.IsGuiZalo.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("GoiSoTiepTheoByDanhMucPhongKhamIDAsync")]
        public virtual async Task<GoiSo> GoiSoTiepTheoByDanhMucPhongKhamIDAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.GoiSoTiepTheoByDanhMucPhongKhamIDAsync(baseParameter.DanhMucPhongKhamID.Value, baseParameter.SoHienTai.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync")]
        public virtual async Task<GoiSo> SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync()
        {
            GoiSo result = new GoiSo();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _GoiSoService.SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync(baseParameter.DanhMucPhongKhamID.Value, baseParameter.GoiSoChiTietID.Value);
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

