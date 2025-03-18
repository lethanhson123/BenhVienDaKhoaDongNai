namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucQRCodeController : BaseController<DanhMucQRCode, IDanhMucQRCodeService>
    {
        private readonly IDanhMucQRCodeService _DanhMucQRCodeService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucQRCodeController(IDanhMucQRCodeService DanhMucQRCodeService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucQRCodeService, WebHostEnvironment)
        {
            _DanhMucQRCodeService = DanhMucQRCodeService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("GetByNumberToListAsync")]
        public async Task<List<DanhMucQRCode>> GetByNumberToListAsync()
        {
            List<DanhMucQRCode> result = new List<DanhMucQRCode>();
            try
            {
                BaseParameter model = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _DanhMucQRCodeService.GetByNumberToListAsync(model.Number.Value);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("GetAllowAnonymousByCodeAsync")]
        public async Task<DanhMucQRCode> GetAllowAnonymousByCodeAsync(string Code)
        {
            DanhMucQRCode result = new DanhMucQRCode();
            try
            {
                //result = await _DanhMucQRCodeService.GetByCodeAsync(Code);


            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return result;
        }
        //[AllowAnonymous]
        //[HttpGet]
        //[Route("GetAllowAnonymousByCode001Async")]
        //public async Task<string> GetAllowAnonymousByCode001Async(string Code)
        //{
        //    string result = GlobalHelper.InitializationString;
        //    DanhMucQRCode model = new DanhMucQRCode();
        //    try
        //    {
        //        //result = await _DanhMucQRCodeService.GetByCodeAsync(Code);
        //        string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
        //        bool isFolderExists = System.IO.Directory.Exists(folderPath);
        //        if (!isFolderExists)
        //        {
        //            System.IO.Directory.CreateDirectory(folderPath);
        //        }

        //        Helper.Model.QRCodeModel QRCodeModel = QRCodeHelper.CreateQRCodeURL(Code, Code, folderPath);

        //        result = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + QRCodeModel.FileName;

        //    }
        //    catch (Exception ex)
        //    {
        //        string mes = ex.Message;
        //    }
        //    return result;
        //}
    }
}

