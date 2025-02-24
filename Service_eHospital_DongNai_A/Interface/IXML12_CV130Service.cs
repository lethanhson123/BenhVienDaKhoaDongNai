namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML12_CV130Service : IBaseService<XML12_CV130>
    {
        Task<List<XML12_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
        Task<List<XML12_CV130>> GetByListIDStringToListAsync(List<string> ListIDString);
    }
}

