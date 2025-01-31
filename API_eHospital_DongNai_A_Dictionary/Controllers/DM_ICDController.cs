namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_ICDController : BaseController<DM_ICD, IDM_ICDService>
    {
        private readonly IDM_ICDService _DM_ICDService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_ICDController(IDM_ICDService DM_ICDService, IWebHostEnvironment WebHostEnvironment) : base(DM_ICDService, WebHostEnvironment)
        {
            _DM_ICDService = DM_ICDService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByICD_Nhom_IdAndEmptyToListAsync")]
        public virtual async Task<List<DM_ICD>> GetByICD_Nhom_IdAndEmptyToListAsync()
        {
            List<DM_ICD> result = new List<DM_ICD>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_ICDService.GetByICD_Nhom_IdAndEmptyToListAsync(baseParameter.ICD_Nhom_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByICD_Nhom_Id_SearchStringAndEmptyToListAsync")]
        public virtual async Task<List<DM_ICD>> GetByICD_Nhom_Id_SearchStringAndEmptyToListAsync()
        {
            List<DM_ICD> result = new List<DM_ICD>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_ICDService.GetByICD_Nhom_Id_SearchStringAndEmptyToListAsync(baseParameter.ICD_Nhom_Id.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

