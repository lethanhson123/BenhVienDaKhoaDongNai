namespace Service_eHospital_DongNai_A.Interface
{
    public interface IBenhAnService : IBaseService<BenhAn>
    {
        Task<BenhAn> GetByBenhAn_IdAsync(int BenhAn_Id);
        Task<List<BenhAn>> GetByNgayVaoVien_SearchStringToListAsync(DateTime NgayVaoVien, string SearchString);
    }
}

