namespace Service.Interface
{
    public interface IThanhVienChucNangService : IBaseService<ThanhVienChucNang>
    {
        Task<List<ThanhVienChucNang>> GetSQLByParentIDToListAsync(long ParentID);
    }
}

