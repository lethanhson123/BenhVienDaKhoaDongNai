namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML5_CV130Service : IBaseService<XML5_CV130>
    {
        Task<List<XML5_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
    }
}

