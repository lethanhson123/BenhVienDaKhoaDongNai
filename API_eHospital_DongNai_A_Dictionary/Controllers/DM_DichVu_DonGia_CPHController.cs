namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_DichVu_DonGia_CPHController : BaseController<DM_DichVu_DonGia_CPH, IDM_DichVu_DonGia_CPHService>
    {
        private readonly IDM_DichVu_DonGia_CPHService _DM_DichVu_DonGia_CPHService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_DichVu_DonGia_CPHController(IDM_DichVu_DonGia_CPHService DM_DichVu_DonGia_CPHService, IWebHostEnvironment WebHostEnvironment) : base(DM_DichVu_DonGia_CPHService, WebHostEnvironment)
        {
            _DM_DichVu_DonGia_CPHService = DM_DichVu_DonGia_CPHService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBangGia_CPH_IdToListAsync")]
        public virtual async Task<List<DM_DichVu_DonGia_CPH>> GetByBangGia_CPH_IdToListAsync()
        {
            List<DM_DichVu_DonGia_CPH> result = new List<DM_DichVu_DonGia_CPH>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DichVu_DonGia_CPHService.GetByBangGia_CPH_IdToListAsync(baseParameter.BangGia_CPH_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByBangGia_CPH_IdAndEmptyToListAsync")]
        public virtual async Task<List<DM_DichVu_DonGia_CPH>> GetByBangGia_CPH_IdAndEmptyToListAsync()
        {
            List<DM_DichVu_DonGia_CPH> result = new List<DM_DichVu_DonGia_CPH>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_DichVu_DonGia_CPHService.GetByBangGia_CPH_IdAndEmptyToListAsync(baseParameter.BangGia_CPH_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

