namespace Service_eHospital_DongNai_A.Interface
{
    public interface IHoaDonChiTietService : IBaseService<HoaDonChiTiet>
    {
        Task<List<HoaDonChiTiet>> GetByListIDToListAsync(List<int?> ListID);
    }
}

