namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML13_CV130Service : IBaseService<XML13_CV130>
    {
        Task<List<XML13_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
        Task<List<XML13_CV130>> GetByListIDStringToListAsync(List<string> ListIDString);
    }
}

