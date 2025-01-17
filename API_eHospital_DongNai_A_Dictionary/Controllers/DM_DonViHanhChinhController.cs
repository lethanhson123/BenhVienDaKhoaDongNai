namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DonViHanhChinhController : BaseController<DM_DonViHanhChinh, IDM_DonViHanhChinhService>
    {
        private readonly IDM_DonViHanhChinhService _DM_DonViHanhChinhService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_DonViHanhChinhController(IDM_DonViHanhChinhService DM_DonViHanhChinhService, IWebHostEnvironment WebHostEnvironment) : base(DM_DonViHanhChinhService, WebHostEnvironment)
        {
            _DM_DonViHanhChinhService = DM_DonViHanhChinhService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByCapDonViToListAsync")]
        public virtual async Task<List<DM_DonViHanhChinh>> GetByCapDonViToListAsync()
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DonViHanhChinhService.GetByCapDonViToListAsync(baseParameter.CapDonVi.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByCapDonViAndEmptyToListAsync")]
        public virtual async Task<List<DM_DonViHanhChinh>> GetByCapDonViAndEmptyToListAsync()
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DonViHanhChinhService.GetByCapDonViAndEmptyToListAsync(baseParameter.CapDonVi.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByCapDonVi_CapTren_IdToListAsync")]
        public virtual async Task<List<DM_DonViHanhChinh>> GetByDictionary_Type_IdAndEmptyToListAsync()
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DonViHanhChinhService.GetByCapDonVi_CapTren_IdToListAsync(baseParameter.CapDonVi.Value, baseParameter.CapTren_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByCapDonVi_CapTren_IdAndEmptyToListAsync")]
        public virtual async Task<List<DM_DonViHanhChinh>> GetByCapDonVi_CapTren_IdAndEmptyToListAsync()
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DonViHanhChinhService.GetByCapDonVi_CapTren_IdAndEmptyToListAsync(baseParameter.CapDonVi.Value, baseParameter.CapTren_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

