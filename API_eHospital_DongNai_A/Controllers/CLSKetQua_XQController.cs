namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQua_XQController : BaseController<CLSKetQua_XQ, ICLSKetQua_XQService>
    {
        private readonly ICLSKetQua_XQService _CLSKetQua_XQService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSKetQua_XQController(ICLSKetQua_XQService CLSKetQua_XQService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQua_XQService, WebHostEnvironment)
        {
            _CLSKetQua_XQService = CLSKetQua_XQService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<CLSKetQua_XQ>> GetByListIDToListAsync()
        {
            List<CLSKetQua_XQ> result = new List<CLSKetQua_XQ>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSKetQua_XQService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

