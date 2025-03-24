namespace API_eHospital_DongNai_A.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class KhamBenh_SinhHieuController : BaseController<KhamBenh_SinhHieu, IKhamBenh_SinhHieuService>
    {
        private readonly IKhamBenh_SinhHieuService _KhamBenh_SinhHieuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public KhamBenh_SinhHieuController(IKhamBenh_SinhHieuService KhamBenh_SinhHieuService, IWebHostEnvironment WebHostEnvironment) : base(KhamBenh_SinhHieuService, WebHostEnvironment)
        {
            _KhamBenh_SinhHieuService = KhamBenh_SinhHieuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBenhNhan_IdToListAsync")]
        public virtual async Task<List<KhamBenh_SinhHieu>> GetByBenhNhan_IdToListAsync()
        {
            List<KhamBenh_SinhHieu> result = new List<KhamBenh_SinhHieu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _KhamBenh_SinhHieuService.GetByBenhNhan_IdToListAsync(baseParameter.BenhNhan_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

