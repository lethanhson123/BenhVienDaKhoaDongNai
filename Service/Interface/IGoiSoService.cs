namespace Service.Interface
{
    public interface IGoiSoService : IBaseService<GoiSo>
    {
        Task<GoiSo> UpdateByDanhMucDichVuID_SoHienTaiAsync(long DanhMucDichVuID, int SoHienTai);
        Task<GoiSo> SaveByDanhMucDichVuIDAsync(long DanhMucDichVuID);
        Task<GoiSo> CreateHTMLByModelAsync(GoiSo result);
    }
}

