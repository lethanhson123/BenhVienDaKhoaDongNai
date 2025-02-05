namespace API_eHospital_DongNai_A_Dictionary.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DM_BenhNhanController : BaseController<DM_BenhNhan, IDM_BenhNhanService>
    {
        private readonly IDM_BenhNhanService _DM_BenhNhanService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DM_BenhNhanController(IDM_BenhNhanService DM_BenhNhanService, IWebHostEnvironment WebHostEnvironment) : base(DM_BenhNhanService, WebHostEnvironment)
        {
            _DM_BenhNhanService = DM_BenhNhanService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByBenhNhan_IdAsync")]
        public virtual async Task<DM_BenhNhan> GetByBenhNhan_IdAsync()
        {
            DM_BenhNhan result = new DM_BenhNhan();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_BenhNhanService.GetByBenhNhan_IdAsync(baseParameter.BenhNhan_Id.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchStringToListAsync")]
        public virtual async Task<List<DM_BenhNhan>> GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchStringToListAsync()
        {
            List<DM_BenhNhan> result = new List<DM_BenhNhan>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_BenhNhanService.GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchStringToListAsync(baseParameter.TinhThanh_Id.Value, baseParameter.QuanHuyen_Id.Value, baseParameter.XaPhuong_Id.Value, baseParameter.SearchString);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByListIDToListAsync")]
        public virtual async Task<List<DM_BenhNhan>> GetByListIDToListAsync()
        {
            List<DM_BenhNhan> result = new List<DM_BenhNhan>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DM_BenhNhanService.GetByListIDToListAsync(baseParameter.ListID);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

