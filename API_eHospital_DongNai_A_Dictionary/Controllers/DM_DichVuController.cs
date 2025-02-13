namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DichVuController : BaseController<DM_DichVu, IDM_DichVuService>
    {
        private readonly IDM_DichVuService _DM_DichVuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_DichVuController(IDM_DichVuService DM_DichVuService, IWebHostEnvironment WebHostEnvironment) : base(DM_DichVuService, WebHostEnvironment)
        {
            _DM_DichVuService = DM_DichVuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByDichVu_IdAsync")]
        public virtual async Task<DM_DichVu> GetByDichVu_IdAsync()
        {
            DM_DichVu result = new DM_DichVu();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DichVuService.GetByDichVu_IdAsync(baseParameter.DichVu_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNhomDichVu_IdAndEmptyToListAsync")]
        public virtual async Task<List<DM_DichVu>> GetByNhomDichVu_IdAndEmptyToListAsync()
        {
            List<DM_DichVu> result = new List<DM_DichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DichVuService.GetByNhomDichVu_IdAndEmptyToListAsync(baseParameter.NhomDichVu_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNhomDichVu_Id_SearchStringToListAsync")]
        public virtual async Task<List<DM_DichVu>> GetByNhomDichVu_Id_SearchStringToListAsync()
        {
            List<DM_DichVu> result = new List<DM_DichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DichVuService.GetByNhomDichVu_Id_SearchStringToListAsync(baseParameter.NhomDichVu_Id.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

