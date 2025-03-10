
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucTinhThanhToaDoController : BaseController<DanhMucTinhThanhToaDo, IDanhMucTinhThanhToaDoService>
    {
        private readonly IDanhMucTinhThanhToaDoService _DanhMucTinhThanhToaDoService;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        private readonly IDanhMucTinhThanhService _DanhMucTinhThanhService;
        private readonly IDanhMucQuanHuyenService _DanhMucQuanHuyenService;
        private readonly IDanhMucXaPhuongService _DanhMucXaPhuongService;
        public DanhMucTinhThanhToaDoController(IDanhMucTinhThanhToaDoService DanhMucTinhThanhToaDoService

            , IWebHostEnvironment WebHostEnvironment

            , IDanhMucTinhThanhService DanhMucTinhThanhService
            , IDanhMucQuanHuyenService DanhMucQuanHuyenService
            , IDanhMucXaPhuongService DanhMucXaPhuongService

            ) : base(DanhMucTinhThanhToaDoService, WebHostEnvironment)
        {
            _DanhMucTinhThanhToaDoService = DanhMucTinhThanhToaDoService;
            _WebHostEnvironment = WebHostEnvironment;

            _DanhMucTinhThanhService = DanhMucTinhThanhService;
            _DanhMucQuanHuyenService = DanhMucQuanHuyenService;
            _DanhMucXaPhuongService = DanhMucXaPhuongService;
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
        [HttpPost]
        [Route("GetByParentID_Active_NumberToListAsync")]
        public async Task<List<DanhMucTinhThanhToaDo>> GetByParentID_Active_NumberToListAsync()
        {
            List<DanhMucTinhThanhToaDo> result = new List<DanhMucTinhThanhToaDo>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucTinhThanhToaDoService.GetByParentID_Active_NumberToListAsync(model.ParentID.Value, model.Active.Value, model.Number.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        
    }
}

