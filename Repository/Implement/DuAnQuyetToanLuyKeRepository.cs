namespace Repository.Implement
{
    public class DuAnQuyetToanLuyKeRepository : BaseRepository<DuAnQuyetToanLuyKe>
    , IDuAnQuyetToanLuyKeRepository
    {
        private readonly Data.Context.Context _context;
        public DuAnQuyetToanLuyKeRepository(Data.Context.Context context) : base(context)
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
            result = await ExecuteNonQueryByStoredProcedureAsync("sp_DuAnQuyetToanLuyKeSyncByID", parameters);
            return result;
        }
    }
}

