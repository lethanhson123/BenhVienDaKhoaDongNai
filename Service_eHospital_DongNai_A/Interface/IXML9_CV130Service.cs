namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML9_CV130Service : IBaseService<XML9_CV130>
    {
        Task<List<XML9_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
    }
}

