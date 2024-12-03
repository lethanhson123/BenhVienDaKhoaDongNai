namespace Service.Interface
{
    public interface IDanhMucDichVuService : IBaseService<DanhMucDichVu>
    {
        Task<List<DanhMucDichVu>> GetByIsBHYTToListAsync(bool IsBHYT);
    }
}

