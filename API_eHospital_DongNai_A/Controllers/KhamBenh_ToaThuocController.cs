namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_ToaThuocController : BaseController<KhamBenh_ToaThuoc, IKhamBenh_ToaThuocService>
    {
        private readonly IKhamBenh_ToaThuocService _KhamBenh_ToaThuocService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public KhamBenh_ToaThuocController(IKhamBenh_ToaThuocService KhamBenh_ToaThuocService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_ToaThuocService, WebHostEnvironment)
        {
            _KhamBenh_ToaThuocService = KhamBenh_ToaThuocService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByKhamBenh_ToaThuoc_IdAsync")]
        public virtual async Task<KhamBenh_ToaThuoc> GetByKhamBenh_ToaThuoc_IdAsync()
        {
            KhamBenh_ToaThuoc result = new KhamBenh_ToaThuoc();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenh_ToaThuocService.GetByKhamBenh_ToaThuoc_IdAsync(baseParameter.KhamBenh_ToaThuoc_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByNgayToaThuoc_SearchStringToListAsync")]
        public virtual async Task<List<KhamBenh_ToaThuoc>> GetByNgayToaThuoc_SearchStringToListAsync()
        {
            List<KhamBenh_ToaThuoc> result = new List<KhamBenh_ToaThuoc>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenh_ToaThuocService.GetByNgayToaThuoc_SearchStringToListAsync(baseParameter.NgayToaThuoc.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

