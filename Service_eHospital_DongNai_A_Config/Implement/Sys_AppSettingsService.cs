using Microsoft.AspNetCore.Hosting;

namespace Service_eHospital_DongNai_A_Config.Implement
{
    public class Sys_AppSettingsService : BaseService<Sys_AppSettings, ISys_AppSettingsRepository>
    , ISys_AppSettingsService
    {
        private readonly ISys_AppSettingsRepository _Sys_AppSettingsRepository;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Sys_AppSettingsService(ISys_AppSettingsRepository Sys_AppSettingsRepository, IWebHostEnvironment webHostEnvironment) : base(Sys_AppSettingsRepository)
        {
            _Sys_AppSettingsRepository = Sys_AppSettingsRepository;
            _WebHostEnvironment = webHostEnvironment;
        }
        public override void Initialization(Sys_AppSettings model)
        {
            BaseInitialization(model);
            if (string.IsNullOrEmpty(model.Language_Id))
            {
                model.Language_Id = "Vi";
            }
            if (model.Locked == null)
            {
                model.Locked = false;
            }
            if (model.SystemEditOnly == null)
            {
                model.SystemEditOnly = true;
            }
        }
        public override async Task<Sys_AppSettings> SaveAsync(Sys_AppSettings model)
        {
            try
            {
                if (model.Setting_Id > 0)
                {
                    await UpdateAsync(model);
                }
                else
                {
                    await AddAsync(model);
                }
                await Sync(model);
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
            }
            return model;
        }
        public override async Task<List<Sys_AppSettings>> GetBySearchStringToListAsync(string searchString)
        {
            List<Sys_AppSettings> result = new List<Sys_AppSettings>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    foreach (string searchStringSub in searchString.Split(';'))
                    {
                        result.AddRange(await GetByCondition(item => item.Setting_Id.Value.ToString() == searchStringSub).ToListAsync());
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (result == null)
            {
                result = new List<Sys_AppSettings>();
            }
            return result;
        }
        public virtual async Task<Sys_AppSettings> Sync(Sys_AppSettings model)
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
                List<Sys_AppSettings> List = await GetAllToListAsync();
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
        public virtual async Task<List<Sys_AppSettings>> KhoiPhucAsync()
        {
            List<Sys_AppSettings> result = new List<Sys_AppSettings>();
            Sys_AppSettings model = new Sys_AppSettings();
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
                        result = JsonConvert.DeserializeObject<List<Sys_AppSettings>>(json);
                    }
                }
            }
            return result;
        }
    }
}

