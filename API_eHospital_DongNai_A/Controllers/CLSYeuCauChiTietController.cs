namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSYeuCauChiTietController : BaseController<CLSYeuCauChiTiet, ICLSYeuCauChiTietService>
    {
        private readonly ICLSYeuCauChiTietService _CLSYeuCauChiTietService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSYeuCauChiTietController(ICLSYeuCauChiTietService CLSYeuCauChiTietService, IWebHostEnvironment WebHostEnvironment) : base(CLSYeuCauChiTietService, WebHostEnvironment)
        {
            _CLSYeuCauChiTietService = CLSYeuCauChiTietService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<CLSYeuCauChiTiet>> GetByListIDToListAsync()
        {
            List<CLSYeuCauChiTiet> result = new List<CLSYeuCauChiTiet>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSYeuCauChiTietService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

