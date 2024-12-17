namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucTinhThanhToaDoController : BaseController<DanhMucTinhThanhToaDo, IDanhMucTinhThanhToaDoService>
    {
        private readonly IDanhMucTinhThanhToaDoService _DanhMucTinhThanhToaDoService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucTinhThanhToaDoController(IDanhMucTinhThanhToaDoService DanhMucTinhThanhToaDoService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucTinhThanhToaDoService, WebHostEnvironment)
        {
            _DanhMucTinhThanhToaDoService = DanhMucTinhThanhToaDoService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync")]
        public async Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync()
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucTinhThanhToaDoService.GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync(model.ParentID.Value, model.Active.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync")]
        public async Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync()
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucTinhThanhToaDoService.GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync(model.ParentID.Value, model.Active.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

