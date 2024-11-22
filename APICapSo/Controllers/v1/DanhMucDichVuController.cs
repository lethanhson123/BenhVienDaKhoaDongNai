using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucDichVuController : BaseController<DanhMucDichVu, IDanhMucDichVuService>
    {
        private readonly IDanhMucDichVuService _DanhMucDichVuService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucDichVuController(IDanhMucDichVuService DanhMucDichVuService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucDichVuService, WebHostEnvironment)
        {
            _DanhMucDichVuService = DanhMucDichVuService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetAllToListAsync")]
        public virtual async Task<List<DanhMucDichVu>> GetAllToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                result = await _DanhMucDichVuService.GetAllToListAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetByActiveToListAsync")]
        public virtual async Task<List<DanhMucDichVu>> GetByActiveToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucDichVuService.GetByActiveToListAsync(baseParameter.Active.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }       
    }
}

