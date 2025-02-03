namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DichVu_DonGiaController : BaseController<DM_DichVu_DonGia, IDM_DichVu_DonGiaService>
    {
        private readonly IDM_DichVu_DonGiaService _DM_DichVu_DonGiaService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_DichVu_DonGiaController(IDM_DichVu_DonGiaService DM_DichVu_DonGiaService, IWebHostEnvironment WebHostEnvironment) : base(DM_DichVu_DonGiaService, WebHostEnvironment)
        {
            _DM_DichVu_DonGiaService = DM_DichVu_DonGiaService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBangGia_IdToListAsync")]
        public virtual async Task<List<DM_DichVu_DonGia>> GetByBangGia_IdToListAsync()
        {
            List<DM_DichVu_DonGia> result = new List<DM_DichVu_DonGia>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DichVu_DonGiaService.GetByBangGia_IdToListAsync(baseParameter.BangGia_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByBangGia_IdAndEmptyToListAsync")]
        public virtual async Task<List<DM_DichVu_DonGia>> GetByBangGia_IdAndEmptyToListAsync()
        {
            List<DM_DichVu_DonGia> result = new List<DM_DichVu_DonGia>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DichVu_DonGiaService.GetByBangGia_IdAndEmptyToListAsync(baseParameter.BangGia_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

