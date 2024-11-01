namespace Service.Interface
{
    public interface IDuAnQuyetToanLuyKeService : IBaseService<DuAnQuyetToanLuyKe>
    {
        Task<List<DuAnQuyetToanLuyKe>> GetBySoQuyetDinhToListAsync(string SoQuyetDinh);
        Task<List<DuAnQuyetToanLuyKe>> GetSQLByParentIDToListAsync(long ParentID);
        Task<List<DuAnQuyetToanLuyKe>> GetSQLBySoQuyetDinhToListAsync(string SoQuyetDinh);
    }
}

