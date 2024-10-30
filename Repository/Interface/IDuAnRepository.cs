namespace Repository.Interface
{
    public interface IDuAnRepository : IBaseRepository<DuAn>
    {
        Task<string> SyncSQLByIDAsync(long ID);
    }
}

