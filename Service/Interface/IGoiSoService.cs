
namespace Service.Interface
{
    public interface IGoiSoService : IBaseService<GoiSo>
    {
        Task<GoiSo> GoiSoTiepTheoAsync(long DanhMucDichVuID, int SoHienTai, long DanhMucQuayDichVuID);
        Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuIDAsync(long DanhMucDichVuID, int SoHienTai, long DanhMucQuayDichVuID, string Code);
        Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuIDAsync(long DanhMucDichVuID, long DanhMucQuayDichVuID);
        Task<GoiSo> GoiSoTiepTheoByDanhMucDichVuID_DanhMucQuayDichVuID_SoHienTai_CodeAsync(long DanhMucDichVuID, long DanhMucQuayDichVuID, int SoHienTai, string Code);
        Task<GoiSo> GoiSoTiepTheoByDanhMucPhongKhamIDAsync(long DanhMucDichVuID, int SoHienTai);
        Task<GoiSo> SaveByDanhMucDichVuIDAsync(long DanhMucDichVuID);
        Task<GoiSo> SaveByDanhMucDichVuID_CodeAsync(long DanhMucDichVuID, string Code);
        Task<GoiSo> SaveByDanhMucDichVuID_Code_DisplayAsync(long DanhMucDichVuID, string Code, string Display);
        Task<GoiSo> SaveByDanhMucDichVuID_Code_Display_IsInPhieu_IsGuiZaloAsync(long DanhMucDichVuID, string Code, string Display, bool IsInPhieu, bool IsGuiZalo);
        Task<GoiSo> SaveByDanhMucPhongKhamID_GoiSoChiTietIDAsync(long DanhMucPhongKhamID, long GoiSoChiTietID);
        Task<GoiSo> CreateHTMLByModelAsync(GoiSo result);
        Task<List<GoiSo>> GetByNgayGhiNhanToListAsync(DateTime NgayGhiNhan);
        Task<List<GoiSo>> GetByYear_Month_DayToListAsync(int Year, int Month, int Day);
        Task<int> Sync_eHospital_DongNai_AAsync();
    }
}

