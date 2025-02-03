namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_BangGia_CPHController : BaseController<DM_BangGia_CPH, IDM_BangGia_CPHService>
    {
        private readonly IDM_BangGia_CPHService _DM_BangGia_CPHService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_BangGia_CPHController(IDM_BangGia_CPHService DM_BangGia_CPHService, IWebHostEnvironment WebHostEnvironment) : base(DM_BangGia_CPHService, WebHostEnvironment)
        {
            _DM_BangGia_CPHService = DM_BangGia_CPHService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBangGia_CPH_IdAsync")]
        public virtual async Task<DM_BangGia_CPH> GetByBangGia_CPH_IdAsync()
        {
            DM_BangGia_CPH result = new DM_BangGia_CPH();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_BangGia_CPHService.GetByBangGia_CPH_IdAsync(baseParameter.BangGia_CPH_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

