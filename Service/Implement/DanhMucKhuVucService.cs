namespace Service.Implement
{
    public class DanhMucKhuVucService : BaseService<DanhMucKhuVuc, IDanhMucKhuVucRepository>
    , IDanhMucKhuVucService
    {
        private readonly IDanhMucKhuVucRepository _DanhMucKhuVucRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucKhuVucService(IDanhMucKhuVucRepository DanhMucKhuVucRepository, IWebHostEnvironment webHostEnvironment) : base(DanhMucKhuVucRepository)
        {
            _DanhMucKhuVucRepository = DanhMucKhuVucRepository;
            _WebHostEnvironment = webHostEnvironment;
        }
        public override async Task<DanhMucKhuVuc> SaveAsync(DanhMucKhuVuc model)
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
        public virtual async Task<DanhMucKhuVuc> Sync(DanhMucKhuVuc model)
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
                List<DanhMucKhuVuc> List = await GetAllToListAsync();
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
        public virtual async Task<List<DanhMucKhuVuc>> KhoiPhucAsync()
        {
            List<DanhMucKhuVuc> result = new List<DanhMucKhuVuc>();
            DanhMucKhuVuc model = new DanhMucKhuVuc();
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
                        result = JsonConvert.DeserializeObject<List<DanhMucKhuVuc>>(json);
                    }
                }
            }
            return result;
        }
    }
}

