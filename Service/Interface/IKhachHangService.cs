namespace Service.Interface
{
    public interface IKhachHangService : IBaseService<KhachHang>
    {
        Task<KhachHang> GetBySearchStringToAsync(string SearchString);
        Task<KhachHang> GetByCodeToAsync(string SearchString);
        Task<KhachHang> GetByBHYTToAsync(string SearchString);
        Task<KhachHang> GetByCCCDToAsync(string SearchString);
        Task<KhachHang> GetByDienThoaiToAsync(string SearchString);
    }
}

