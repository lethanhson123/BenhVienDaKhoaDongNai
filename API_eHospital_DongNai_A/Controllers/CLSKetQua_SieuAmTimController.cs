namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQua_SieuAmTimController : BaseController<CLSKetQua_SieuAmTim, ICLSKetQua_SieuAmTimService>
    {
        private readonly ICLSKetQua_SieuAmTimService _CLSKetQua_SieuAmTimService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSKetQua_SieuAmTimController(ICLSKetQua_SieuAmTimService CLSKetQua_SieuAmTimService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQua_SieuAmTimService, WebHostEnvironment)
        {
            _CLSKetQua_SieuAmTimService = CLSKetQua_SieuAmTimService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<CLSKetQua_SieuAmTim>> GetByListIDToListAsync()
        {
            List<CLSKetQua_SieuAmTim> result = new List<CLSKetQua_SieuAmTim>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSKetQua_SieuAmTimService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

