using Microsoft.AspNetCore.Hosting;

namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class Lst_Dictionary_TypeService : BaseService<Lst_Dictionary_Type, ILst_Dictionary_TypeRepository>
    , ILst_Dictionary_TypeService
    {
        private readonly ILst_Dictionary_TypeRepository _Lst_Dictionary_TypeRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Lst_Dictionary_TypeService(ILst_Dictionary_TypeRepository Lst_Dictionary_TypeRepository, IWebHostEnvironment webHostEnvironment) : base(Lst_Dictionary_TypeRepository)
        {
            _Lst_Dictionary_TypeRepository = Lst_Dictionary_TypeRepository;
            _WebHostEnvironment = webHostEnvironment;
        }
        public override async Task<Lst_Dictionary_Type> SaveAsync(Lst_Dictionary_Type model)
        {
            if (model.Dictionary_Type_Id > 0)
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
        public virtual async Task<Lst_Dictionary_Type> Sync(Lst_Dictionary_Type model)
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
                List<Lst_Dictionary_Type> List = await GetAllToListAsync();
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
        public virtual async Task<List<Lst_Dictionary_Type>> KhoiPhucAsync()
        {
            List<Lst_Dictionary_Type> result = new List<Lst_Dictionary_Type>();
            Lst_Dictionary_Type model = new Lst_Dictionary_Type();
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
                        result = JsonConvert.DeserializeObject<List<Lst_Dictionary_Type>>(json);
                    }
                }
            }
            return result;
        }
    }
}

