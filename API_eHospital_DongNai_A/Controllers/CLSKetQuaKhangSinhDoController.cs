namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQuaKhangSinhDoController : BaseController<CLSKetQuaKhangSinhDo, ICLSKetQuaKhangSinhDoService>
    {
        private readonly ICLSKetQuaKhangSinhDoService _CLSKetQuaKhangSinhDoService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSKetQuaKhangSinhDoController(ICLSKetQuaKhangSinhDoService CLSKetQuaKhangSinhDoService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQuaKhangSinhDoService, WebHostEnvironment)
        {
            _CLSKetQuaKhangSinhDoService = CLSKetQuaKhangSinhDoService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<CLSKetQuaKhangSinhDo>> GetByListIDToListAsync()
        {
            List<CLSKetQuaKhangSinhDo> result = new List<CLSKetQuaKhangSinhDo>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSKetQuaKhangSinhDoService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

