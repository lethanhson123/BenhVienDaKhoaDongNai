
namespace Service.Interface
{
    public interface IGoiSoService : IBaseService<GoiSo>
    {
        Task<GoiSo> GoiSoTiepTheoAsync(long DanhMucDichVuID, int SoHienTai,long DanhMucQuayDichVuID);
        Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuIDAsync(long DanhMucDichVuID, int SoHienTai, long DanhMucQuayDichVuID, string Code);
        Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync(long DanhMucDichVuID, long DanhMucQuayDichVuID, int SoHienTai, string Code);
        Task<GoiSo> GoiSoTiepTheoByDanhMucPhongKhamIDAsync(long DanhMucDichVuID, int SoHienTai);
        Task<GoiSo> SaveByDanhMucDichVuIDAsync(long DanhMucDichVuID);
        Task<GoiSo> SaveByDanhMucDichVuID_CodeAsync(long DanhMucDichVuID, string Code);
        Task<GoiSo> SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync(long DanhMucPhongKhamID, long GoiSoChiTietID);
        Task<GoiSo> CreateHTMLByModelAsync(GoiSo result);
        Task<List<GoiSo>> GetByNgayGhiNhanToListAsync(DateTime NgayGhiNhan);
    }
}

