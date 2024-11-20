namespace Service.Interface
{
    public interface IThanhVienDichVuService : IBaseService<ThanhVienDichVu>
    {
        Task<List<ThanhVienDichVu>> GetSQLByParentIDToListAsync(long ParentID);
    }
}

