namespace Service_eHospital_DongNai_A.Interface
{
    public interface IXML10_CV130Service : IBaseService<XML10_CV130>
    {
        Task<List<XML10_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString);
    }
}

