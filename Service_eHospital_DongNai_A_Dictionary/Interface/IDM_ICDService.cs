namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_ICDService : IBaseService<DM_ICD>
    {
        Task<List<DM_ICD>> GetByICD_Nhom_IdAndEmptyToListAsync(int ICD_Nhom_Id);
        Task<List<DM_ICD>> GetByICD_Nhom_Id_SearchStringAndEmptyToListAsync(int ICD_Nhom_Id, string SearchString);
    }
}

