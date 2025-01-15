namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface ILst_DictionaryService : IBaseService<Lst_Dictionary>
    {
        Task<List<Lst_Dictionary>> GetByDictionary_Type_IdToListAsync(int Dictionary_Type_Id);
        Task<List<Lst_Dictionary>> GetByDictionary_Type_IdAndEmptyToListAsync(int Dictionary_Type_Id);
    }
}

