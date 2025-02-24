namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML12_CV130Controller : BaseController<XML12_CV130, IXML12_CV130Service>
    {
        private readonly IXML12_CV130Service _XML12_CV130Service;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public XML12_CV130Controller(IXML12_CV130Service XML12_CV130Service, IWebHostEnvironment WebHostEnvironment) : base(XML12_CV130Service, WebHostEnvironment)
        {
            _XML12_CV130Service = XML12_CV130Service;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByYear_Month_SearchStringToListAsync")]
        public virtual async Task<List<XML12_CV130>> GetByYear_Month_SearchStringToListAsync()
        {
            List<XML12_CV130> result = new List<XML12_CV130>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _XML12_CV130Service.GetByYear_Month_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByListIDStringToListAsync")]
        public virtual async Task<List<XML12_CV130>> GetByListIDStringToListAsync()
        {
            List<XML12_CV130> result = new List<XML12_CV130>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _XML12_CV130Service.GetByListIDStringToListAsync(baseParameter.ListIDString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

