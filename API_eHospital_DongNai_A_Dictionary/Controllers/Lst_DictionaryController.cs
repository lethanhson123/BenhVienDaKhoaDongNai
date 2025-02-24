namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class Lst_DictionaryController : BaseController<Lst_Dictionary, ILst_DictionaryService>
    {
        private readonly ILst_DictionaryService _Lst_DictionaryService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Lst_DictionaryController(ILst_DictionaryService Lst_DictionaryService, IWebHostEnvironment WebHostEnvironment) : base(Lst_DictionaryService, WebHostEnvironment)
        {
            _Lst_DictionaryService = Lst_DictionaryService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByDictionary_Type_IdToListAsync")]
        public virtual async Task<List<Lst_Dictionary>> GetByDictionary_Type_IdToListAsync()
        {
            List<Lst_Dictionary> result = new List<Lst_Dictionary>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Lst_DictionaryService.GetByDictionary_Type_IdToListAsync(baseParameter.Dictionary_Type_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByDictionary_Type_IdAndEmptyToListAsync")]
        public virtual async Task<List<Lst_Dictionary>> GetByDictionary_Type_IdAndEmptyToListAsync()
        {
            List<Lst_Dictionary> result = new List<Lst_Dictionary>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _Lst_DictionaryService.GetByDictionary_Type_IdAndEmptyToListAsync(baseParameter.Dictionary_Type_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("KhoiPhucAsync")]
        public virtual async Task<List<Lst_Dictionary>> KhoiPhucAsync()
        {
            List<Lst_Dictionary> result = new List<Lst_Dictionary>();
            try
            {
                result = await _Lst_DictionaryService.KhoiPhucAsync();
                foreach (Lst_Dictionary item in result)
                {
                    await _Lst_DictionaryService.SaveAsync(item);
                    result.Add(item);
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

