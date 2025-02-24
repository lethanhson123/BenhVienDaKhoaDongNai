namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML1_CV130Controller : BaseController<XML1_CV130, IXML1_CV130Service>
    {
        private readonly IXML1_CV130Service _XML1_CV130Service;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public XML1_CV130Controller(IXML1_CV130Service XML1_CV130Service, IWebHostEnvironment WebHostEnvironment) : base(XML1_CV130Service, WebHostEnvironment)
        {
            _XML1_CV130Service = XML1_CV130Service;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByYear_Month_SearchStringToListAsync")]
        public virtual async Task<List<XML1_CV130>> GetByYear_Month_SearchStringToListAsync()
        {
            List<XML1_CV130> result = new List<XML1_CV130>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _XML1_CV130Service.GetByYear_Month_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByYear_Month_Day_SearchStringToListAsync")]
        public virtual async Task<List<XML1_CV130>> GetByYear_Month_Day_SearchStringToListAsync()
        {
            List<XML1_CV130> result = new List<XML1_CV130>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _XML1_CV130Service.GetByYear_Month_Day_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.Day.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

