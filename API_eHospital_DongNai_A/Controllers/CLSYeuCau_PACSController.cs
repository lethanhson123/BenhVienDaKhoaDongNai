namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSYeuCau_PACSController : BaseController<CLSYeuCau_PACS, ICLSYeuCau_PACSService>
    {
        private readonly ICLSYeuCau_PACSService _CLSYeuCau_PACSService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSYeuCau_PACSController(ICLSYeuCau_PACSService CLSYeuCau_PACSService, IWebHostEnvironment WebHostEnvironment) : base(CLSYeuCau_PACSService, WebHostEnvironment)
        {
            _CLSYeuCau_PACSService = CLSYeuCau_PACSService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<CLSYeuCau_PACS>> GetByListIDToListAsync()
        {
            List<CLSYeuCau_PACS> result = new List<CLSYeuCau_PACS>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSYeuCau_PACSService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

