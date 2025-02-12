namespace Service.Interface
{
    public interface IDanhMucDichVuService : IBaseService<DanhMucDichVu>
    {
        Task<List<DanhMucDichVu>> GetByIsBHYTToListAsync(bool IsBHYT);
        Task<List<DanhMucDichVu>> GetByThanhVienID_ActiveToListAsync(long ThanhVienID, bool Active);
        Task<List<DanhMucDichVu>> KhoiPhucAsync();
        
    }
}

