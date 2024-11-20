namespace Service.Interface
{
    public interface IThanhVienPhongKhamService : IBaseService<ThanhVienPhongKham>
    {
        Task<List<ThanhVienPhongKham>> GetSQLByParentIDToListAsync(long ParentID);
    }
}

