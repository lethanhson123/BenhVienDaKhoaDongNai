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
        [HttpGet]
        [AllowAnonymous]
        [Route("ZaloSendMessageAsync")]
        public virtual async Task<int> ZaloSendMessageAsync()
        {
            int result = GlobalHelper.InitializationNumber;
            try
            {
                string access_token = "3Fu29uTy8mm0_m8jYNyX0GV_1Y2DOr5pVAil798qIan3j0m_X2jfQ77sBpUU559zQ_8h790sRNP0znTNe79eV2UmI2VDOIz6Ew5i4CzY75T6jteUidKxJ6wMSIsEHGW3GALEI9TuDZXtZtH3_6SKCoUKT4VzSL0L3FGwNlqVMW4A_dXMupO1377RHo6T6IrUOFrQ1xvuVt9BW09JXmDvVc3zEJIu6tGLO94iOhvsIIeob09ArND0FoIjVtV1L1GCIz53Hwq9CWjsWdH6_NOUEJ2qVLZ-K1SOCjPkRw0C1YreqqHsaYWQMLliEok7PcDbNkKpH9OpRYbZrKztiZKsAcF6V76b8JOQIzPJSfSrC21brd9vgW4h2bV5QNJSCHyA6kjhHEqwG3u-mseLnoKETNLBlx8I68TY90e";
                

            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
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
        [Route("GetByIsBHYTToListAsync")]
        public virtual async Task<List<DanhMucDichVu>> GetByIsBHYTToListAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucDichVuService.GetByIsBHYTToListAsync(baseParameter.IsBHYT.Value);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
    }
}

