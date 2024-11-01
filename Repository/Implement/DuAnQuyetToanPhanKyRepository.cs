namespace Repository.Implement
{
    public class DuAnQuyetToanPhanKyRepository : BaseRepository<DuAnQuyetToanPhanKy>
    , IDuAnQuyetToanPhanKyRepository
    {
        private readonly Data.Context.Context _context;
        public DuAnQuyetToanPhanKyRepository(Data.Context.Context context) : base(context)
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
            result = await ExecuteNonQueryByStoredProcedureAsync("sp_DuAnQuyetToanPhanKySyncByID", parameters);
            return result;
        }
    }
}

