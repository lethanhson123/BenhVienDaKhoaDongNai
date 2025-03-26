namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class BenhAnChiTietController : BaseController<BenhAnChiTiet, IBenhAnChiTietService>
    {
        private readonly IBenhAnChiTietService _BenhAnChiTietService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public BenhAnChiTietController(IBenhAnChiTietService BenhAnChiTietService, IWebHostEnvironment WebHostEnvironment) : base(BenhAnChiTietService, WebHostEnvironment)
        {
            _BenhAnChiTietService = BenhAnChiTietService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<BenhAnChiTiet>> GetByListIDToListAsync()
        {
            List<BenhAnChiTiet> result = new List<BenhAnChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BenhAnChiTietService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

