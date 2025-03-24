namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class CLSKetQua_ImagesController : BaseController<CLSKetQua_Images, ICLSKetQua_ImagesService>
    {
        private readonly ICLSKetQua_ImagesService _CLSKetQua_ImagesService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public CLSKetQua_ImagesController(ICLSKetQua_ImagesService CLSKetQua_ImagesService, IWebHostEnvironment WebHostEnvironment) : base(CLSKetQua_ImagesService, WebHostEnvironment)
        {
            _CLSKetQua_ImagesService = CLSKetQua_ImagesService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<CLSKetQua_Images>> GetByListIDToListAsync()
        {
            List<CLSKetQua_Images> result = new List<CLSKetQua_Images>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _CLSKetQua_ImagesService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

