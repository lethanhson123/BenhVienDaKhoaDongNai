namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML14_CV130Service : IBaseService<XML14_CV130>
    {
        Task<List<XML14_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
    }
}

