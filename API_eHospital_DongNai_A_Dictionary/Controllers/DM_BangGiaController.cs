namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_BangGiaController : BaseController<DM_BangGia, IDM_BangGiaService>
    {
        private readonly IDM_BangGiaService _DM_BangGiaService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_BangGiaController(IDM_BangGiaService DM_BangGiaService, IWebHostEnvironment WebHostEnvironment) : base(DM_BangGiaService, WebHostEnvironment)
        {
            _DM_BangGiaService = DM_BangGiaService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBangGia_IdAsync")]
        public virtual async Task<DM_BangGia> GetByBangGia_IdAsync()
        {
            DM_BangGia result = new DM_BangGia();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_BangGiaService.GetByBangGia_IdAsync(baseParameter.BangGia_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

