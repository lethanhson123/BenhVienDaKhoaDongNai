namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML3_CV130Service : IBaseService<XML3_CV130>
    {
        Task<List<XML3_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
        Task<List<XML3_CV130>> GetByListIDStringToListAsync(List<string> ListIDString);
    }
}

