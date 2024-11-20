namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThanhVienDichVuController : BaseController<ThanhVienDichVu, IThanhVienDichVuService>
    {
        private readonly IThanhVienDichVuService _ThanhVienDichVuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThanhVienDichVuController(IThanhVienDichVuService ThanhVienDichVuService, IWebHostEnvironment WebHostEnvironment) : base(ThanhVienDichVuService, WebHostEnvironment)
        {
            _ThanhVienDichVuService = ThanhVienDichVuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetSQLByParentIDToListAsync")]
        public async Task<List<ThanhVienDichVu>> GetSQLByParentIDToListAsync()
        {
            List<ThanhVienDichVu> result = new List<ThanhVienDichVu>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ThanhVienDichVuService.GetSQLByParentIDToListAsync(model.ParentID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

