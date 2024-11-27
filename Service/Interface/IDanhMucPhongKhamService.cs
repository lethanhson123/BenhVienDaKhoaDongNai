namespace Service.Interface
{
    public interface IDanhMucPhongKhamService : IBaseService<DanhMucPhongKham>
    {
        Task<List<DanhMucPhongKham>> GetSQLByParentIDToListAsync(long ParentID);
        Task<List<DanhMucPhongKham>> GetSQLBySearchStringViaIDToListAsync(string SearchString);
        Task<List<DanhMucPhongKham>> GetSQLBySearchStringViaNameToListAsync(string SearchString);
    }
}

