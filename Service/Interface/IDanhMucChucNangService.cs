namespace Service.Interface
{
    public interface IDanhMucChucNangService : IBaseService<DanhMucChucNang>
    {
        Task<List<DanhMucChucNang>> GetSQLByThanhVienID_ActiveToListAsync(long ThanhVienID, bool Active);
        Task<List<DanhMucChucNang>> GetByThanhVienID_ActiveToListAsync(long ThanhVienID, bool Active);
    }
}

