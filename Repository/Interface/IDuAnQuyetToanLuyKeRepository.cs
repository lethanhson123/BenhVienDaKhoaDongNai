namespace Repository.Interface
{
    public interface IDuAnQuyetToanLuyKeRepository : IBaseRepository<DuAnQuyetToanLuyKe>
    {
        Task<string> SyncSQLByIDAsync(long ID);
    }
}

