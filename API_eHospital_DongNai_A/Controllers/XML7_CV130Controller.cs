namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML7_CV130Controller : BaseController<XML7_CV130, IXML7_CV130Service>
    {
        private readonly IXML7_CV130Service _XML7_CV130Service;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public XML7_CV130Controller(IXML7_CV130Service XML7_CV130Service, IWebHostEnvironment WebHostEnvironment) : base(XML7_CV130Service, WebHostEnvironment)
        {
            _XML7_CV130Service = XML7_CV130Service;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByYear_Month_SearchStringToListAsync")]
        public virtual async Task<List<XML7_CV130>> GetByYear_Month_SearchStringToListAsync()
        {
            List<XML7_CV130> result = new List<XML7_CV130>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _XML7_CV130Service.GetByYear_Month_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

