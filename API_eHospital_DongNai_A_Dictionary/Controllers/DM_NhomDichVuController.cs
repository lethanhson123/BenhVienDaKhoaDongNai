namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_NhomDichVuController : BaseController<DM_NhomDichVu, IDM_NhomDichVuService>
    {
        private readonly IDM_NhomDichVuService _DM_NhomDichVuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_NhomDichVuController(IDM_NhomDichVuService DM_NhomDichVuService, IWebHostEnvironment WebHostEnvironment) : base(DM_NhomDichVuService, WebHostEnvironment)
        {
            _DM_NhomDichVuService = DM_NhomDichVuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByLoaiDichVu_IdAndEmptyToListAsync")]
        public virtual async Task<List<DM_NhomDichVu>> GetByLoaiDichVu_IdAndEmptyToListAsync()
        {
            List<DM_NhomDichVu> result = new List<DM_NhomDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_NhomDichVuService.GetByLoaiDichVu_IdAndEmptyToListAsync(baseParameter.LoaiDichVu_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

