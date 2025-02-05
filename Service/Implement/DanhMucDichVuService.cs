using Microsoft.AspNetCore.Hosting;

namespace Service.Implement
{
    public class DanhMucDichVuService : BaseService<DanhMucDichVu, IDanhMucDichVuRepository>
    , IDanhMucDichVuService
    {
        private readonly IDanhMucDichVuRepository _DanhMucDichVuRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucDichVuService(IDanhMucDichVuRepository DanhMucDichVuRepository, IWebHostEnvironment webHostEnvironment) : base(DanhMucDichVuRepository)
        {
            _DanhMucDichVuRepository = DanhMucDichVuRepository;
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
    }
}

