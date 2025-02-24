namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML1_CV130Service : IBaseService<XML1_CV130>
    {
        Task<List<XML1_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
        Task<List<XML1_CV130>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString);
    }
}

