namespace Service.Interface
{
    public interface IDuAnQuyetDinhService : IBaseService<DuAnQuyetDinh>
    {
        Task<List<DuAnQuyetDinh>> GetSQLByThanhVienIDToListAsync(long ThanhVienID);
    }
}

