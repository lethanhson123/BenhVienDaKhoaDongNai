namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML7_CV130Service : IBaseService<XML7_CV130>
    {
        Task<List<XML7_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
        Task<List<XML7_CV130>> GetByListIDStringToListAsync(List<string> ListIDString);
    }
}

