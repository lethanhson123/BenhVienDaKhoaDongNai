namespace Service.Interface
{
    public interface ICongViecService : IBaseService<CongViec>
    {
        Task<List<CongViec>> GetBySearchString_BatDau_KetThucToListAsync(string SearchString, DateTime BatDau, DateTime KetThuc);
        Task<List<CongViec>> GetByThanhVienIDToListAsync(long ThanhVienID);
    }
}

