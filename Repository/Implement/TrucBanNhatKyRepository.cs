namespace Repository.Implement
{
    public class TrucBanNhatKyRepository : BaseRepository<TrucBanNhatKy>
    , ITrucBanNhatKyRepository
    {
        private readonly Data.Context.Context _context;
        public TrucBanNhatKyRepository(Data.Context.Context context) : base(context)
        {
            _context = context;
        }
    }
}

