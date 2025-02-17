namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML2_CV130Service : IBaseService<XML2_CV130>
    {
        Task<List<XML2_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
    }
}

