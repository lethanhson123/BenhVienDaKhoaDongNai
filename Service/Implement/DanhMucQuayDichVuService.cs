using Microsoft.AspNetCore.Hosting;
using Service.Interface;

namespace Service.Implement
{
    public class DanhMucQuayDichVuService : BaseService<DanhMucQuayDichVu, IDanhMucQuayDichVuRepository>
    , IDanhMucQuayDichVuService
    {
        private readonly IDanhMucQuayDichVuRepository _DanhMucQuayDichVuRepository;

        private readonly IDanhMucKhuVucRepository _DanhMucKhuVucRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public DanhMucQuayDichVuService(IDanhMucQuayDichVuRepository DanhMucQuayDichVuRepository
            
            , IDanhMucKhuVucRepository danhMucKhuVucRepository

            , IWebHostEnvironment webHostEnvironment

            ) : base(DanhMucQuayDichVuRepository)
        {
            _DanhMucQuayDichVuRepository = DanhMucQuayDichVuRepository;
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
    }
}

