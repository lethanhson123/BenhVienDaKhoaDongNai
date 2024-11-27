namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucPhongKhamController : BaseController<DanhMucPhongKham, IDanhMucPhongKhamService>
    {
        private readonly IDanhMucPhongKhamService _DanhMucPhongKhamService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucPhongKhamController(IDanhMucPhongKhamService DanhMucPhongKhamService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucPhongKhamService, WebHostEnvironment)
        {
            _DanhMucPhongKhamService = DanhMucPhongKhamService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetSQLByParentIDToListAsync")]
        public virtual async Task<List<DanhMucPhongKham>> GetSQLByParentIDToListAsync()
        {
            List<DanhMucPhongKham> result = new List<DanhMucPhongKham>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucPhongKhamService.GetSQLByParentIDToListAsync(baseParameter.ParentID.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLBySearchStringViaIDToListAsync")]
        public virtual async Task<List<DanhMucPhongKham>> GetSQLBySearchStringViaIDToListAsync()
        {
            List<DanhMucPhongKham> result = new List<DanhMucPhongKham>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucPhongKhamService.GetSQLBySearchStringViaIDToListAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSQLBySearchStringViaNameToListAsync")]
        public virtual async Task<List<DanhMucPhongKham>> GetSQLBySearchStringViaNameToListAsync()
        {
            List<DanhMucPhongKham> result = new List<DanhMucPhongKham>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucPhongKhamService.GetSQLBySearchStringViaNameToListAsync(baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        
    }
}

