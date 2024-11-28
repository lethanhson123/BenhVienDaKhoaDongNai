namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ThanhVienUngDungController : BaseController<ThanhVienUngDung, IThanhVienUngDungService>
    {
        private readonly IThanhVienUngDungService _ThanhVienUngDungService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ThanhVienUngDungController(IThanhVienUngDungService ThanhVienUngDungService, IWebHostEnvironment WebHostEnvironment) : base(ThanhVienUngDungService, WebHostEnvironment)
        {
            _ThanhVienUngDungService = ThanhVienUngDungService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetSQLByParentIDToListAsync")]
        public async Task<List<ThanhVienUngDung>> GetSQLByParentIDToListAsync()
        {
            List<ThanhVienUngDung> result = new List<ThanhVienUngDung>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ThanhVienUngDungService.GetSQLByParentIDToListAsync(model.ParentID.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
    }
}

