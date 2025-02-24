using Microsoft.AspNetCore.Hosting;
using System.Runtime.CompilerServices;

namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class Lst_DictionaryService : BaseService<Lst_Dictionary, ILst_DictionaryRepository>
    , ILst_DictionaryService
    {
        private readonly ILst_DictionaryRepository _Lst_DictionaryRepository;

        private readonly IWebHostEnvironment _WebHostEnvironment;
        public Lst_DictionaryService(ILst_DictionaryRepository Lst_DictionaryRepository, IWebHostEnvironment webHostEnvironment) : base(Lst_DictionaryRepository)
        {
            _Lst_DictionaryRepository = Lst_DictionaryRepository;
            _WebHostEnvironment = webHostEnvironment;
        }
        public override async Task<Lst_Dictionary> SaveAsync(Lst_Dictionary model)
        {
            if (model.Dictionary_Id > 0)
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
        public virtual async Task<List<Lst_Dictionary>> GetByDictionary_Type_IdToListAsync(int Dictionary_Type_Id)
        {
            List<Lst_Dictionary> result = new List<Lst_Dictionary>();
            if (Dictionary_Type_Id > 0)
            {
                result = await GetByCondition(item => item.Dictionary_Type_Id == Dictionary_Type_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Lst_Dictionary>();
            }
            return result;
        }
        public virtual async Task<List<Lst_Dictionary>> GetByDictionary_Type_IdAndEmptyToListAsync(int Dictionary_Type_Id)
        {
            List<Lst_Dictionary> result = new List<Lst_Dictionary>();
            Lst_Dictionary empty = new Lst_Dictionary();
            result.Add(empty);
            List<Lst_Dictionary> list = await GetByDictionary_Type_IdToListAsync(Dictionary_Type_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
        public virtual async Task<Lst_Dictionary> Sync(Lst_Dictionary model)
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
                List<Lst_Dictionary> List = await GetAllToListAsync();
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
        public virtual async Task<List<Lst_Dictionary>> KhoiPhucAsync()
        {
            List<Lst_Dictionary> result = new List<Lst_Dictionary>();
            Lst_Dictionary model = new Lst_Dictionary();
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
                        result = JsonConvert.DeserializeObject<List<Lst_Dictionary>>(json);
                    }
                }
            }
            return result;
        }
    }
}

