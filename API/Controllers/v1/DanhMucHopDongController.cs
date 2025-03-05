namespace API.Controllers.v1
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class DanhMucHopDongController : BaseController<DanhMucHopDong, IDanhMucHopDongService>
    {
        private readonly IDanhMucHopDongService _DanhMucHopDongService;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucHopDongController(IDanhMucHopDongService DanhMucHopDongService, IWebHostEnvironment WebHostEnvironment) : base(DanhMucHopDongService, WebHostEnvironment)
        {
            _DanhMucHopDongService = DanhMucHopDongService;
            _WebHostEnvironment = WebHostEnvironment;
        }
        [HttpPost]
        [Route("SaveAndUploadFileAsync")]
        public override async Task<DanhMucHopDong> SaveAndUploadFileAsync()
        {
            DanhMucHopDong model = JsonConvert.DeserializeObject<DanhMucHopDong>(Request.Form["data"]);
            try
            {
                string folderPath = GlobalHelper.InitializationString;
                string physicalPath = GlobalHelper.InitializationString;
                bool isFolderExists = GlobalHelper.InitializationBool;
                try
                {
                    if (Request.Form.Files.Count > 0)
                    {
                        var file = Request.Form.Files[0];
                        if (file == null || file.Length == 0)
                        {
                        }
                        if (file != null)
                        {
                            string fileExtension = Path.GetExtension(file.FileName);
                            model.FileName = model.GetType().Name + "_" + model.ID + "_" + GlobalHelper.InitializationDateTimeCode0001 + fileExtension;
                            folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                            isFolderExists = System.IO.Directory.Exists(folderPath);
                            if (!isFolderExists)
                            {
                                System.IO.Directory.CreateDirectory(folderPath);
                            }
                            physicalPath = Path.Combine(folderPath, model.FileName);
                            using (var stream = new FileStream(physicalPath, FileMode.Create))
                            {
                                file.CopyTo(stream);                                
                                model.FileName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + model.FileName;

                            }

                            byte[] byteArray = System.IO.File.ReadAllBytes(physicalPath);
                            using (MemoryStream stream = new MemoryStream())
                            {
                                stream.Write(byteArray, 0, (int)byteArray.Length);
                                using (WordprocessingDocument doc = WordprocessingDocument.Open(stream, true))
                                {

                                    HtmlConverterSettings settings = new HtmlConverterSettings()
                                    {
                                        PageTitle = model.Name,
                                    };
                                    XElement html = HtmlConverter.ConvertToHtml(doc, settings);

                                    model.HTMLContent = html.ToStringNewLineOnAttributes();

                                    HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                                    document.LoadHtml(model.HTMLContent);
                                    var nodes = document.DocumentNode.SelectNodes("//body");
                                    foreach (var node in nodes)
                                    {
                                        model.HTMLContent = node.OuterHtml;
                                    }
                                    model.HTMLContent = model.HTMLContent.Replace(@"<body", @"<p");
                                    model.HTMLContent = model.HTMLContent.Replace(@"</body>", @"<p>");
                                    model.HTMLContent = model.HTMLContent.Replace(@"<div", @"<p");
                                    model.HTMLContent = model.HTMLContent.Replace(@"</div>", @"</p>");
                                    model.HTMLContent = model.HTMLContent.Replace(@"<h1", @"<p");
                                    model.HTMLContent = model.HTMLContent.Replace(@"</h1>", @"</p>");
                                    model.HTMLContent = model.HTMLContent.Replace(@"<h2", @"<p");
                                    model.HTMLContent = model.HTMLContent.Replace(@"</h2>", @"</p>");
                                    model.HTMLContent = model.HTMLContent.Replace(@"<h3", @"<p");
                                    model.HTMLContent = model.HTMLContent.Replace(@"</h3>", @"</p>");
                                    model.HTMLContent = model.HTMLContent.Replace(@"<h4", @"<p");
                                    model.HTMLContent = model.HTMLContent.Replace(@"</h4>", @"</p>");
                                    model.HTMLContent = model.HTMLContent.Replace(@"<h5", @"<p");
                                    model.HTMLContent = model.HTMLContent.Replace(@"</h5>", @"</p>");
                                    model.HTMLContent = model.HTMLContent.Replace(@"<h6", @"<p");
                                    model.HTMLContent = model.HTMLContent.Replace(@"</h6>", @"</p>");
                                    model.HTMLContent = model.HTMLContent.Replace(@"<table", @"<table class=""border""");
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    string mes = e.Message;
                }
                if (string.IsNullOrEmpty(model.HTMLContent))
                {
                    model.HTMLContent = GlobalHelper.InitializationString;
                }
                if (model.HTMLContent.Contains(GlobalHelper.MainContent) == false)
                {
                    if (model.Active == true)
                    {
                        string HTMLContent = GlobalHelper.InitializationString;
                        var physicalPathRead = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Download, GlobalHelper.BieuMauFileName);
                        using (FileStream fs = new FileStream(physicalPathRead, FileMode.Open))
                        {
                            using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                            {
                                HTMLContent = r.ReadToEnd();
                            }
                        }
                        model.HTMLContent = HTMLContent.Replace(GlobalHelper.MainContent, model.HTMLContent);                        
                    }
                }

                model.TypeName = model.GetType().Name + "_" + model.ID + "_" + GlobalHelper.InitializationDateTimeCode0001 + ".html";
                folderPath = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
                physicalPath = Path.Combine(folderPath, model.TypeName);
                isFolderExists = System.IO.Directory.Exists(folderPath);
                if (!isFolderExists)
                {
                    System.IO.Directory.CreateDirectory(folderPath);
                }
                using (FileStream fs = new FileStream(physicalPath, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine(model.HTMLContent);
                        model.TypeName = GlobalHelper.APISite + "/" + model.GetType().Name + "/" + model.TypeName;
                    }
                }
            }
            catch (Exception e)
            {
                string mes = e.Message;
            }
            await _DanhMucHopDongService.SaveAsync(model);
            return model;
        }
    }
}

