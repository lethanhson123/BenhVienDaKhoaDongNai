namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class XML10_CV130Controller : BaseController<XML10_CV130, IXML10_CV130Service>
    {
        private readonly IXML10_CV130Service _XML10_CV130Service;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public XML10_CV130Controller(IXML10_CV130Service XML10_CV130Service, IWebHostEnvironment WebHostEnvironment) : base(XML10_CV130Service, WebHostEnvironment)
        {
            _XML10_CV130Service = XML10_CV130Service;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByYear_Month_SearchStringToListAsync")]
        public virtual async Task<List<XML10_CV130>> GetByYear_Month_SearchStringToListAsync()
        {
            List<XML10_CV130> result = new List<XML10_CV130>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _XML10_CV130Service.GetByYear_Month_SearchStringToListAsync(baseParameter.Year.Value, baseParameter.Month.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByListIDStringToListAsync")]
        public virtual async Task<List<XML10_CV130>> GetByListIDStringToListAsync()
        {
            List<XML10_CV130> result = new List<XML10_CV130>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _XML10_CV130Service.GetByListIDStringToListAsync(baseParameter.ListIDString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

