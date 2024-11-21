
namespace Service.Interface
{
    public interface IGoiSoService : IBaseService<GoiSo>
    {
        Task<GoiSo> GoiSoTiepTheoAsync(long DanhMucDichVuID, int SoHienTai,long DanhMucQuayDichVuID);
        Task<GoiSo> SaveByDanhMucDichVuIDAsync(long DanhMucDichVuID);
        Task<GoiSo> CreateHTMLByModelAsync(GoiSo result);
    }
}

