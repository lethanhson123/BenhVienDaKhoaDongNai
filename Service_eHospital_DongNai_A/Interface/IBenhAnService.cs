namespace Service_eHospital_DongNai_A.Interface
{
    public interface IBenhAnService : IBaseService<BenhAn>
    {
        Task<BenhAn> GetByBenhAn_IdAsync(int BenhAn_Id);
        Task<List<BenhAn>> GetByNgayVaoVien_SearchStringToListAsync(DateTime NgayVaoVien, string SearchString);
        Task<List<BenhAn>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString);
    }
}

