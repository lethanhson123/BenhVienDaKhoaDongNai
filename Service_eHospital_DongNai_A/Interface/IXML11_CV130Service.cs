namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML11_CV130Service : IBaseService<XML11_CV130>
    {
        Task<List<XML11_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
        Task<List<XML11_CV130>> GetByListIDStringToListAsync(List<string> ListIDString);
    }
}

