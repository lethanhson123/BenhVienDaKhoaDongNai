namespace Repository.Interface
{
    public interface IDuAnQuyetToanPhanKyRepository : IBaseRepository<DuAnQuyetToanPhanKy>
    {
        Task<string> SyncSQLByIDAsync(long ID);
    }
}

