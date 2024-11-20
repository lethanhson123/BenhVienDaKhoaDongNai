namespace Service.Interface
{
    public interface IGoiSoService : IBaseService<GoiSo>
    {
        Task<GoiSo> SaveByDanhMucDichVuIDAsync(long DanhMucDichVuID);
        Task<GoiSo> CreateHTMLByModelAsync(GoiSo result);
    }
}

