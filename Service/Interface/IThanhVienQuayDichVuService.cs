namespace Service.Interface
{
    public interface IThanhVienQuayDichVuService : IBaseService<ThanhVienQuayDichVu>
    {
        Task<List<ThanhVienQuayDichVu>> GetSQLByParentIDToListAsync(long ParentID);
    }
}

