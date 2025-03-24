namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaChiTietController : BaseController<CLSKetQuaChiTiet, ICLSKetQuaChiTietService>
    {
        private readonly ICLSKetQuaChiTietService _CLSKetQuaChiTietService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSKetQuaChiTietController(ICLSKetQuaChiTietService CLSKetQuaChiTietService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaChiTietService, WebHostEnvironment)
        {
            _CLSKetQuaChiTietService = CLSKetQuaChiTietService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<CLSKetQuaChiTiet>> GetByListIDToListAsync()
        {
            List<CLSKetQuaChiTiet> result = new List<CLSKetQuaChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSKetQuaChiTietService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

