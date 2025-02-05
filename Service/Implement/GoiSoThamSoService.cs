using Azure.Core;
using Microsoft.AspNetCore.Hosting;

namespace Service.Implement
{
    public class GoiSoThamSoService : BaseService<GoiSoThamSo, IGoiSoThamSoRepository>
    , IGoiSoThamSoService
    {
        private readonly IGoiSoThamSoRepository _GoiSoThamSoRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public GoiSoThamSoService(IGoiSoThamSoRepository GoiSoThamSoRepository, IWebHostEnvironment webHostEnvironment) : base(GoiSoThamSoRepository)
        {
            _GoiSoThamSoRepository = GoiSoThamSoRepository;
            _WebHostEnvironment = webHostEnvironment;
        }
        public override async Task<GoiSoThamSo> SaveAsync(GoiSoThamSo model)
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
        public virtual async Task<GoiSoThamSo> Sync(GoiSoThamSo model)
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
                List<GoiSoThamSo> List = await GetAllToListAsync();
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
        public virtual async Task<List<GoiSoThamSo>> KhoiPhucAsync()
        {
            List<GoiSoThamSo> result = new List<GoiSoThamSo>();
            GoiSoThamSo model = new GoiSoThamSo();
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
                        result = JsonConvert.DeserializeObject<List<GoiSoThamSo>>(json);
                    }
                }
            }
            return result;
        }
    }
}

