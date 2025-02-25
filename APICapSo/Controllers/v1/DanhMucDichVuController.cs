namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucDichVuController : BaseController<DanhMucDichVu, IDanhMucDichVuService>
    {
        private readonly IDanhMucDichVuService _DanhMucDichVuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucDichVuController(IDanhMucDichVuService DanhMucDichVuService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucDichVuService, WebHostEnvironment)
        {
            _DanhMucDichVuService = DanhMucDichVuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        
        [HttpPost]
        [Route("GetAllToListAsync")]
        public virtual async Task<List<DanhMucDichVu>> GetAllToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                result = await _DanhMucDichVuService.GetAllToListAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByThanhVienID_ActiveToListAsync")]
        public async Task<List<DanhMucDichVu>> GetByThanhVienID_ActiveToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucDichVuService.GetByThanhVienID_ActiveToListAsync(model.ThanhVienID.Value, model.Active.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("GetAllowAnonymousByThanhVienID_ActiveToListAsync")]
        public async Task<List<DanhMucDichVu>> GetAllowAnonymousByThanhVienID_ActiveToListAsync(long ThanhVienID, bool Active)
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {                
                result = await _DanhMucDichVuService.GetByThanhVienID_ActiveToListAsync(ThanhVienID, Active);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByIsBHYTToListAsync")]
        public virtual async Task<List<DanhMucDichVu>> GetByIsBHYTToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucDichVuService.GetByIsBHYTToListAsync(baseParameter.IsBHYT.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

