namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_BenhNhan_BHYTController : BaseController<DM_BenhNhan_BHYT, IDM_BenhNhan_BHYTService>
    {
        private readonly IDM_BenhNhan_BHYTService _DM_BenhNhan_BHYTService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_BenhNhan_BHYTController(IDM_BenhNhan_BHYTService DM_BenhNhan_BHYTService, IWebHostEnvironment WebHostEnvironment) : base(DM_BenhNhan_BHYTService, WebHostEnvironment)
        {
            _DM_BenhNhan_BHYTService = DM_BenhNhan_BHYTService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBenhNhan_IdToListAsync")]
        public virtual async Task<List<DM_BenhNhan_BHYT>> GetByBenhNhan_IdToListAsync()
        {
            List<DM_BenhNhan_BHYT> result = new List<DM_BenhNhan_BHYT>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_BenhNhan_BHYTService.GetByBenhNhan_IdToListAsync(baseParameter.BenhNhan_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByBenhNhan_IdAndEmptyToListAsync")]
        public virtual async Task<List<DM_BenhNhan_BHYT>> GetByBenhNhan_IdAndEmptyToListAsync()
        {
            List<DM_BenhNhan_BHYT> result = new List<DM_BenhNhan_BHYT>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_BenhNhan_BHYTService.GetByBenhNhan_IdAndEmptyToListAsync(baseParameter.BenhNhan_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

