namespace API.Controllers.v1
{    
    public class BaseController<T, TBaseService> : Controller
        where T : BaseModel
        where TBaseService : IBaseService<T>
    {
        private readonly TBaseService _BaseService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public BaseController(TBaseService baseService
            , IWebHostEnvironment WebHostEnvironment)
        {
            _BaseService = baseService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByIDAsync")]
        public virtual async Task<T> GetByIDAsync()
        {
            T result = (T)Activator.CreateInstance(typeof(T));
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BaseService.GetByIDAsync(baseParameter.ID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNameAsync")]
        public virtual async Task<T> GetByNameAsync()
        {
            T result = (T)Activator.CreateInstance(typeof(T));
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BaseService.GetByNameAsync(baseParameter.Name);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                result.Note = message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByParentIDToListAsync")]
        public virtual async Task<List<T>> GetByParentIDToListAsync()
        {
            List<T> result = new List<T>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _BaseService.GetByParentIDToListAsync(baseParameter.ParentID.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}
