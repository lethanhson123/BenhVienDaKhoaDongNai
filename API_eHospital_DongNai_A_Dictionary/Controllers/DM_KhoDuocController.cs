namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_KhoDuocController : BaseController<DM_KhoDuoc, IDM_KhoDuocService>
    {
        private readonly IDM_KhoDuocService _DM_KhoDuocService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_KhoDuocController(IDM_KhoDuocService DM_KhoDuocService, IWebHostEnvironment WebHostEnvironment) : base(DM_KhoDuocService, WebHostEnvironment)
        {
            _DM_KhoDuocService = DM_KhoDuocService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByPhongBan_IdAndEmptyToListAsync")]
        public virtual async Task<List<DM_KhoDuoc>> GetByPhongBan_IdAndEmptyToListAsync()
        {
            List<DM_KhoDuoc> result = new List<DM_KhoDuoc>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_KhoDuocService.GetByPhongBan_IdAndEmptyToListAsync(baseParameter.PhongBan_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

