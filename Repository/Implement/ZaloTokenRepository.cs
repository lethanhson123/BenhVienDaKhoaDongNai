namespace Repository.Implement
{
    public class ZaloTokenRepository : BaseRepository<ZaloToken>
    , IZaloTokenRepository
    {
        private readonly Data.Context.Context _context;
        public ZaloTokenRepository(Data.Context.Context context) : base(context)
        {
            _context = context;
        }
    }
}

