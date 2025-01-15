using System.Runtime.CompilerServices;

namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class Lst_DictionaryService : BaseService<Lst_Dictionary, ILst_DictionaryRepository>
    , ILst_DictionaryService
    {
        private readonly ILst_DictionaryRepository _Lst_DictionaryRepository;
        public Lst_DictionaryService(ILst_DictionaryRepository Lst_DictionaryRepository) : base(Lst_DictionaryRepository)
        {
            _Lst_DictionaryRepository = Lst_DictionaryRepository;
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
    }
}

