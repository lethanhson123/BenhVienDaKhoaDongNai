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
        [Route("GetByActiveToListAsync")]
        public override async Task<List<ManHinhTapTinDinhKem>> GetByActiveToListAsync()
        {
            List<ManHinhTapTinDinhKem> result = new List<ManHinhTapTinDinhKem>();
            try
            {
                BaseParameter baseParameter = JsonConvert.DeserializeObject<BaseParameter>(Request.Form["data"]);
                result = await _ManHinhTapTinDinhKemService.GetByActiveToListAsync(baseParameter.Active.Value);
                if (result.Count > 0)
                {
                    for (int i = 0; i < result.Count; i++)
                    {
                        result[i].Note = GlobalHelper.InitializationDateTimeCode;
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            return result;
        }
        [HttpPost]
        [Route("GetSyncToTranferListAsync")]
        public virtual async Task<List<ManHinhTapTinDinhKemTranfer>> GetSyncToTranferListAsync()
        {
            List<ManHinhTapTinDinhKemTranfer> result = new List<ManHinhTapTinDinhKemTranfer>();
            ManHinhTapTinDinhKem model = new ManHinhTapTinDinhKem();
            try
            {
                string contentHTML = GlobalHelper.InitializationString;
                string physicalPathOpen = Path.Combine(GlobalHelper.APIFTP, model.GetType().Name, model.GetType().Name + ".json");
                using (FileStream fs = new FileStream(physicalPathOpen, FileMode.Open))
                {
                    using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                    {
                        contentHTML = r.ReadToEnd();
                    }
                }

                if (!string.IsNullOrEmpty(contentHTML))
                {

                    result = JsonConvert.DeserializeObject<List<ManHinhTapTinDinhKemTranfer>>(contentHTML);
                    if (result != null)
                    {
                        if (result.Count > 0)
                        {
                            for (int i = 0; i < result.Count; i++)
                            {
                                if (result[i].IsChanged == true)
                                {
                                    if (GlobalHelper.InitializationDateTime.Date > result[i].LastUpdatedDate.Value.Date)
                                    {
                                        result[i].IsChanged = false;
                                    }
                                }
                            }

                            
                            contentHTML = JsonConvert.SerializeObject(result);
                            string physicalPathCreate = Path.Combine(GlobalHelper.APIFTP, model.GetType().Name);
                            bool isFolderExists = System.IO.Directory.Exists(physicalPathCreate);
                            if (!isFolderExists)
                            {
                                System.IO.Directory.CreateDirectory(physicalPathCreate);
                            }
                            string fileName = model.GetType().Name + ".json";
                            physicalPathCreate = Path.Combine(physicalPathCreate, fileName);
                            using (FileStream fs = new FileStream(physicalPathCreate, FileMode.Create))
                            {
                                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                                {
                                    w.WriteLine(contentHTML);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            if (result == null)
            {
                result = new List<ManHinhTapTinDinhKemTranfer>();
            }
            return result;
        }
    }
}


