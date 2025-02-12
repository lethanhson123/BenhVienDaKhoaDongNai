using Microsoft.AspNetCore.Hosting;

namespace Service.Implement
{
    public class DanhMucDichVuService : BaseService<DanhMucDichVu, IDanhMucDichVuRepository>
    , IDanhMucDichVuService
    {
        private readonly IDanhMucDichVuRepository _DanhMucDichVuRepository;
        private readonly IThanhVienRepository _ThanhVienRepository;
        private readonly IThanhVienDichVuRepository _ThanhVienDichVuRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucDichVuService(IDanhMucDichVuRepository DanhMucDichVuRepository

            , IThanhVienRepository ThanhVienRepository

            , IThanhVienDichVuRepository ThanhVienDichVuRepository

            , IWebHostEnvironment webHostEnvironment) : base(DanhMucDichVuRepository)
        {
            _DanhMucDichVuRepository = DanhMucDichVuRepository;
            _ThanhVienRepository = ThanhVienRepository;
            _ThanhVienDichVuRepository = ThanhVienDichVuRepository;
            _WebHostEnvironment = webHostEnvironment;
        }
        public override void Initialization(DanhMucDichVu model)
        {
            BaseInitialization(model);
            if (model.IsHangDoiPhanNhanh == null)
            {
                model.IsHangDoiPhanNhanh = false;
            }
        }
        public override async Task<DanhMucDichVu> SaveAsync(DanhMucDichVu model)
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
        public virtual async Task<List<DanhMucDichVu>> GetByIsBHYTToListAsync(bool IsBHYT)
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            try
            {
                result = await GetByCondition(item => item.IsBHYT == IsBHYT).ToListAsync();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            if (result == null)
            {
                result = new List<DanhMucDichVu>();
            }
            return result;
        }
        public virtual async Task<List<DanhMucDichVu>> GetByThanhVienID_ActiveToListAsync(long ThanhVienID, bool Active)
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            List<long> ListID = await _ThanhVienDichVuRepository.GetByCondition(item => item.ParentID == ThanhVienID && item.Active == Active).Select(item => item.DanhMucDichVuID.Value).ToListAsync();
            result = await GetByCondition(item => item.Active == Active && ListID.Contains(item.ID)).ToListAsync();
            if (result == null)
            {
                result = new List<DanhMucDichVu>();
            }
            return result;
        }
        public virtual async Task<DanhMucDichVu> Sync(DanhMucDichVu model)
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
                List<DanhMucDichVu> List = await GetAllToListAsync();
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
        public virtual async Task<List<DanhMucDichVu>> KhoiPhucAsync()
        {
            List<DanhMucDichVu> result = new List<DanhMucDichVu>();
            DanhMucDichVu model = new DanhMucDichVu();
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
                        result = JsonConvert.DeserializeObject<List<DanhMucDichVu>>(json);
                    }
                }
            }
            return result;
        }
        public virtual async Task<string> SendMailAsync()
        {
            string result = GlobalHelper.InitializationDateTimeCode0001;
            DanhMucDichVu model = new DanhMucDichVu();
            Helper.Model.Mail mail = new Helper.Model.Mail();
            mail.MailFrom = GlobalHelper.MasterEmailUser;
            mail.UserName = GlobalHelper.MasterEmailUser;
            mail.Password = GlobalHelper.MasterEmailPassword;
            mail.SMTPPort = GlobalHelper.SMTPPort;
            mail.SMTPServer = GlobalHelper.SMTPServer;
            mail.IsMailBodyHtml = GlobalHelper.IsMailBodyHtml;
            mail.IsMailUsingSSL = GlobalHelper.IsMailUsingSSL;
            mail.Display = GlobalHelper.MasterEmailDisplay;
            mail.Subject = "Quầy tiếp nhận - " + GlobalHelper.InitializationDateTime.ToString("dd/MM/yyyy HH:mm:ss") + " | " + GlobalHelper.MasterEmailDisplay;
            string contentHTML = GlobalHelper.InitializationString;
            var physicalPathRead = Path.Combine(_WebHostEnvironment.WebRootPath, GlobalHelper.Download, "DanhMucDichVu.html");
            using (FileStream fs = new FileStream(physicalPathRead, FileMode.Open))
            {
                using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
                {
                    contentHTML = r.ReadToEnd();
                }
            }
            List<DanhMucDichVu> List = await GetAllToListAsync();
            StringBuilder Content = new StringBuilder();
            foreach (DanhMucDichVu DanhMucDichVu in List)
            {
                Content.AppendLine(@"<tr>");
                Content.AppendLine(@"<td>");
                Content.AppendLine(@"" + DanhMucDichVu.Name);
                Content.AppendLine(@"</td>");
                Content.AppendLine(@"<td>");
                Content.AppendLine(@"" + DanhMucDichVu.Active);
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

