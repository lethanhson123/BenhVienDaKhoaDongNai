namespace Service.Interface
{
    public interface IDuAnQuyetToanPhanKyService : IBaseService<DuAnQuyetToanPhanKy>
    {
        Task<List<DuAnQuyetToanPhanKy>> GetBySoQuyetDinhToListAsync(string SoQuyetDinh);
        Task<List<DuAnQuyetToanPhanKy>> GetSQLByParentIDToListAsync(long ParentID);
        Task<List<DuAnQuyetToanPhanKy>> GetSQLBySoQuyetDinhToListAsync(string SoQuyetDinh);
        Task<List<DuAnQuyetToanPhanKy>> GetSQLByDuAnQuyetDinhIDToListAsync(long DuAnQuyetDinhID);
    }
}

