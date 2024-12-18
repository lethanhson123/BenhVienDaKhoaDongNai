using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;

namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ManHinhTapTinDinhKemController : BaseController<ManHinhTapTinDinhKem, IManHinhTapTinDinhKemService>
    {
        private readonly IManHinhTapTinDinhKemService _ManHinhTapTinDinhKemService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ManHinhTapTinDinhKemController(IManHinhTapTinDinhKemService ManHinhTapTinDinhKemService, IWebHostEnvironment WebHostEnvironment) : base(ManHinhTapTinDinhKemService, WebHostEnvironment)
        {
            _ManHinhTapTinDinhKemService = ManHinhTapTinDinhKemService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]        
        [Route("SaveAndUploadFileAsync")]
        public override async Task<ManHinhTapTinDinhKem> SaveAndUploadFileAsync()
        {
            ManHinhTapTinDinhKem model = new ManHinhTapTinDinhKem();
            try
            {
                model = JsonConvert.DeserializeObject<ManHinhTapTinDinhKem>(Request.Form["data"]);
                if (Request.Form.Files.Count > 0)
                {
                    var file = Request.Form.Files[0];
                    if (file == null || file.Length == 0)
                    {
                    }
                    if (file != null)
                    {
                        model.TypeName = Path.GetExtension(file.FileName);
                        model.FileName = model.GetType().Name + "_" + model.ID + "_" + GlobalHelper.InitializationDateTimeCode0001 + model.TypeName;
                        string folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                        bool isFolderExists = System.IO.Directory.Exists(folderPath);
                        if (!isFolderExists)
                        {
                            System.IO.Directory.CreateDirectory(folderPath);
                        }
                        var physicalPath = Path.Combine(folderPath, model.FileName);
                        using (var stream = new FileStream(physicalPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            model.FileName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + model.FileName;
                        }
                    }
                }
                await _ManHinhTapTinDinhKemService.SaveAsync(model);
            }
            catch (Exception e)
            {
                string mes = e.Message;
            }
            return model;
        }
    }
}

