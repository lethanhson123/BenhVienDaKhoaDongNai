namespace Service.Interface
{
    public interface IDanhMucTinhThanhToaDoService : IBaseService<DanhMucTinhThanhToaDo>
    {
        Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucQuanHuyenByParentID_ActiveToListAsync(long ParentID, bool Active);
        Task<List<DanhMucTinhThanhToaDo>> GetSQLDanhMucXaPhuongByParentID_ActiveToListAsync(long ParentID, bool Active);
    }
}

