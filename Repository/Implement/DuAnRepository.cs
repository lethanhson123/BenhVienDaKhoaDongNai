namespace Repository.Implement
{
    public class DuAnRepository : BaseRepository<DuAn>
    , IDuAnRepository
    {
        private readonly Data.Context.Context _context;
        public DuAnRepository(Data.Context.Context context) : base(context)
        {
            _context = context;
        }
        public virtual async Task<string> SyncSQLByIDAsync(long ID)
        {
            string result = GlobalHelper.InitializationString;
            SqlParameter[] parameters =
            {
                    new SqlParameter("@ID",ID),
            };
            result = await ExecuteNonQueryByStoredProcedureAsync("sp_DuAnSyncByID", parameters);
            return result;
        }
    }
}

