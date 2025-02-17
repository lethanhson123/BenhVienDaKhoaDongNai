namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML6_CV130Service : IBaseService<XML6_CV130>
    {
        Task<List<XML6_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
    }
}

