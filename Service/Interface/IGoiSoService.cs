
namespace Service.Interface
{
    public interface IGoiSoService : IBaseService<GoiSo>
    {
        Task<GoiSo> GoiSoTiepTheoAsync(long DanhMucDichVuID, int SoHienTai,long DanhMucQuayDichVuID);
        Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuIDAsync(long DanhMucDichVuID, int SoHienTai, long DanhMucQuayDichVuID, string Code);
        Task<GoiSo> GoiSoTiepTheoByDanhMucPhongKhamIDAsync(long DanhMucDichVuID, int SoHienTai);
        Task<GoiSo> SaveByDanhMucDichVuIDAsync(long DanhMucDichVuID);
        Task<GoiSo> SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync(long DanhMucPhongKhamID, long GoiSoChiTietID);
        Task<GoiSo> CreateHTMLByModelAsync(GoiSo result);
        Task<List<GoiSo>> GetByNgayGhiNhanToListAsync(DateTime NgayGhiNhan);
    }
}

