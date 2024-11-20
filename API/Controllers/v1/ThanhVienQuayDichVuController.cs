namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThanhVienQuayDichVuController : BaseController<ThanhVienQuayDichVu, IThanhVienQuayDichVuService>
    {
        private readonly IThanhVienQuayDichVuService _ThanhVienQuayDichVuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThanhVienQuayDichVuController(IThanhVienQuayDichVuService ThanhVienQuayDichVuService, IWebHostEnvironment WebHostEnvironment) : base(ThanhVienQuayDichVuService, WebHostEnvironment)
        {
            _ThanhVienQuayDichVuService = ThanhVienQuayDichVuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetSQLByParentIDToListAsync")]
        public async Task<List<ThanhVienQuayDichVu>> GetSQLByParentIDToListAsync()
        {
            List<ThanhVienQuayDichVu> result = new List<ThanhVienQuayDichVu>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ThanhVienQuayDichVuService.GetSQLByParentIDToListAsync(model.ParentID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

