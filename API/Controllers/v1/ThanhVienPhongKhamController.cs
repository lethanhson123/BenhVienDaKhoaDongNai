namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThanhVienPhongKhamController : BaseController<ThanhVienPhongKham, IThanhVienPhongKhamService>
    {
        private readonly IThanhVienPhongKhamService _ThanhVienPhongKhamService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThanhVienPhongKhamController(IThanhVienPhongKhamService ThanhVienPhongKhamService, IWebHostEnvironment WebHostEnvironment) : base(ThanhVienPhongKhamService, WebHostEnvironment)
        {
            _ThanhVienPhongKhamService = ThanhVienPhongKhamService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetSQLByParentIDToListAsync")]
        public async Task<List<ThanhVienPhongKham>> GetSQLByParentIDToListAsync()
        {
            List<ThanhVienPhongKham> result = new List<ThanhVienPhongKham>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ThanhVienPhongKhamService.GetSQLByParentIDToListAsync(model.ParentID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

