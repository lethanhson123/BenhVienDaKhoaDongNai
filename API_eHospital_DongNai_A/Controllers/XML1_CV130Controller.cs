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
        [HttpPost]
        [Route("GetXMLCV130TagAsync")]
        public virtual async Task<XMLCV130Tag> GetXMLCV130TagAsync()
        {
            XMLCV130Tag result = new XMLCV130Tag();
            try
            {
                string fileName02 = result.GetType().Name + ".json";
                string path02 = Path.Combine(_WebHostEnvironment.WebRootPath, fileName02);
                bool isFileExists = System.IO.File.Exists(path02);
                if (isFileExists)
                {
                    using (FileStream fs = new FileStream(path02, FileMode.Open))
                    {
                        using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                        {
                            string json = r.ReadToEnd();
                            result = JsonConvert.DeserializeObject<XMLCV130Tag>(json);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("SaveXMLCV130TagAsync")]
        public virtual async Task<XMLCV130Tag> SaveXMLCV130TagAsync()
        {
            XMLCV130Tag result = new XMLCV130Tag();
            try
            {
                result = JsonConvert.DeserializeObject<XMLCV130Tag>(Request.Form["data"]);
                string fileName01 = result.GetType().Name + ".json";
                string path01 = Path.Combine(_WebHostEnvironment.WebRootPath, fileName01);
                bool isFileExists = System.IO.File.Exists(path01);
                string json = JsonConvert.SerializeObject(result);
                using (FileStream fs = new FileStream(path01, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine(json);
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

