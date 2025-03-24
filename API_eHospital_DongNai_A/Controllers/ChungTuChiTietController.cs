namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ChungTuChiTietController : BaseController<ChungTuChiTiet, IChungTuChiTietService>
    {
        private readonly IChungTuChiTietService _ChungTuChiTietService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ChungTuChiTietController(IChungTuChiTietService ChungTuChiTietService, IWebHostEnvironment WebHostEnvironment) : base(ChungTuChiTietService, WebHostEnvironment)
        {
            _ChungTuChiTietService = ChungTuChiTietService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<ChungTuChiTiet>> GetByListIDToListAsync()
        {
            List<ChungTuChiTiet> result = new List<ChungTuChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ChungTuChiTietService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

