namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class NhanVien_User_MappingController : BaseController<NhanVien_User_Mapping, INhanVien_User_MappingService>
    {
        private readonly INhanVien_User_MappingService _NhanVien_User_MappingService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public NhanVien_User_MappingController(INhanVien_User_MappingService NhanVien_User_MappingService, IWebHostEnvironment WebHostEnvironment) : base(NhanVien_User_MappingService, WebHostEnvironment)
        {
            _NhanVien_User_MappingService = NhanVien_User_MappingService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByNhanVien_IdToListAsync")]
        public virtual async Task<List<NhanVien_User_Mapping>> GetByNhanVien_IdToListAsync()
        {
            List<NhanVien_User_Mapping> result = new List<NhanVien_User_Mapping>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NhanVien_User_MappingService.GetByNhanVien_IdToListAsync(baseParameter.NhanVien_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNhanVien_IdAndEmptyToListAsync")]
        public virtual async Task<List<NhanVien_User_Mapping>> GetByNhanVien_IdAndEmptyToListAsync()
        {
            List<NhanVien_User_Mapping> result = new List<NhanVien_User_Mapping>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NhanVien_User_MappingService.GetByNhanVien_IdAndEmptyToListAsync(baseParameter.NhanVien_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_IdToListAsync")]
        public virtual async Task<List<NhanVien_User_Mapping>> GetByUser_IdToListAsync()
        {
            List<NhanVien_User_Mapping> result = new List<NhanVien_User_Mapping>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NhanVien_User_MappingService.GetByUser_IdToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByUser_IdAndEmptyToListAsync")]
        public virtual async Task<List<NhanVien_User_Mapping>> GetByUser_IdAndEmptyToListAsync()
        {
            List<NhanVien_User_Mapping> result = new List<NhanVien_User_Mapping>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _NhanVien_User_MappingService.GetByUser_IdAndEmptyToListAsync(baseParameter.User_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

