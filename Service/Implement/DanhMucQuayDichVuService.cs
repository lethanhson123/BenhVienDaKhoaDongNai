namespace Service.Implement
{
    public class DanhMucQuayDichVuService : BaseService<DanhMucQuayDichVu, IDanhMucQuayDichVuRepository>
    , IDanhMucQuayDichVuService
    {
        private readonly IDanhMucQuayDichVuRepository _DanhMucQuayDichVuRepository;

        private readonly IThanhVienRepository _ThanhVienRepository;

        private readonly IDanhMucKhuVucRepository _DanhMucKhuVucRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucQuayDichVuService(IDanhMucQuayDichVuRepository DanhMucQuayDichVuRepository

            , IThanhVienRepository ThanhVienRepository

            , IDanhMucKhuVucRepository danhMucKhuVucRepository

            , IWebHostEnvironment webHostEnvironment

            ) : base(DanhMucQuayDichVuRepository)
        {
            _DanhMucQuayDichVuRepository = DanhMucQuayDichVuRepository;
            _ThanhVienRepository = ThanhVienRepository;
            _DanhMucKhuVucRepository = danhMucKhuVucRepository;
            _WebHostEnvironment = webHostEnvironment;
        }
        public override void Initialization(DanhMucQuayDichVu model)
        {
            BaseInitialization(model);

            if (model.ParentID > 0)
            {
                model.ParentName = _DanhMucKhuVucRepository.GetByID(model.ParentID.Value).Name;
            }
            if (model.TypeName == null)
            {
                model.TypeName = GlobalHelper.ManHinhMauChu;
            }
            if (model.Interval == null)
            {
                model.Interval = GlobalHelper.Interval;
            }
        }
        public override async Task<DanhMucQuayDichVu> SaveAsync(DanhMucQuayDichVu model)
        {
            if (model.ID > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            await Sync(model);
            return model;
        }
        public virtual async Task<DanhMucQuayDichVu> Sync(DanhMucQuayDichVu model)
        {
            string folderPathRoot = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
            bool isFolderExists = System.IO.Directory.Exists(folderPathRoot);
            if (!isFolderExists)
            {
                System.IO.Directory.CreateDirectory(folderPathRoot);
            }
            string fileName = model.GetType().Name + ".json";
            string path = Path.Combine(folderPathRoot, fileName);
            bool isFileExists = System.IO.File.Exists(path);
            if (!isFileExists)
            {
                List<DanhMucQuayDichVu> List = await GetAllToListAsync();
                string json = JsonConvert.SerializeObject(List);
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        w.WriteLine(json);
                    }
                }
            }
            return model;
        }
        public virtual async Task<List<DanhMucQuayDichVu>> KhoiPhucAsync()
        {
            List<DanhMucQuayDichVu> result = new List<DanhMucQuayDichVu>();
            DanhMucQuayDichVu model = new DanhMucQuayDichVu();
            string folderPathRoot = Path.Combine(_WebHostEnvironment.WebRootPath, model.GetType().Name);
            bool isFolderExists = System.IO.Directory.Exists(folderPathRoot);
            if (!isFolderExists)
            {
                System.IO.Directory.CreateDirectory(folderPathRoot);
            }
            string fileName = model.GetType().Name + ".json";
            string path = Path.Combine(folderPathRoot, fileName);
            bool isFileExists = System.IO.File.Exists(path);
            if (isFileExists)
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                    {
                        string json = r.ReadToEnd();
                        result = JsonConvert.DeserializeObject<List<DanhMucQuayDichVu>>(json);
                    }
                }
            }
            return result;
        }
        public virtual async Task<string> SendMailAsync()
        {
            string result = GlobalHelper.InitializationDateTimeCode0001;
            DanhMucQuayDichVu model = new DanhMucQuayDichVu();
            Helper.Model.Mail mail = new Helper.Model.Mail();
            mail.MailFrom = GlobalHelper.MasterEmailUser;
            mail.UserName = GlobalHelper.MasterEmailUser;
            mail.Password = GlobalHelper.MasterEmailPassword;
            mail.SMTPPort = GlobalHelper.SMTPPort;
            mail.SMTPServer = GlobalHelper.SMTPServer;
            mail.IsMailBodyHtml = GlobalHelper.IsMailBodyHtml;
            mail.IsMailUsingSSL = GlobalHelper.IsMailUsingSSL;
            mail.Display = GlobalHelper.MasterEmailDisplay;
            mail.Subject = "Quầy tiếp nhận - " + GlobalHelper.InitializationDateTime.ToString("dd/MM/yyyy HH:mm:ss") + " | Gọi số";
            string contentHTML = GlobalHelper.InitializationString;
            var physicalPathRead = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Download, "DanhMucQuayDichVu.html");
            using (FileStream fs = new FileStream(physicalPathRead, FileMode.Open))
            {
                using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                {
                    contentHTML = r.ReadToEnd();
                }
            }
            List<DanhMucQuayDichVu> List = await GetAllToListAsync();
            StringBuilder Content = new StringBuilder();
            foreach (DanhMucQuayDichVu DanhMucQuayDichVu in List)
            {
                Content.AppendLine(@"<tr>");
                Content.AppendLine(@"<td>");
                Content.AppendLine(@"<div style='border-bottom: 1px #000000 dashed; padding: 5px; text-align: center;'>");
                Content.AppendLine(@"" + DanhMucQuayDichVu.Name);
                Content.AppendLine(@"</div>");
                Content.AppendLine(@"</td>");
                Content.AppendLine(@"<td>");
                Content.AppendLine(@"<div style='border-bottom: 1px #000000 dashed; padding: 5px; text-align: center;'>");
                Content.AppendLine(@"" + DanhMucQuayDichVu.Active);
                Content.AppendLine(@"<div>");
                Content.AppendLine(@"</td>");
                Content.AppendLine(@"</tr>");
            }
            contentHTML = contentHTML.Replace("[Content]", Content.ToString());
            mail.Content = contentHTML;
            ThanhVien ThanhVien = await _ThanhVienRepository.GetByIDAsync(GlobalHelper.ThanhVienID);
            if (!string.IsNullOrEmpty(ThanhVien.Email))
            {
                mail.Content = contentHTML;
                mail.MailTo = ThanhVien.Email;
                MailHelper.SendMail(mail);
            }
            return result;
        }
    }
}

