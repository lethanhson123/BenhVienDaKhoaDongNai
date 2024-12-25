namespace Repository.Implement
{
    public class ZaloZNSRepository : BaseRepository<ZaloZNS>
    , IZaloZNSRepository
    {
        private readonly Data.Context.Context _context;
        public ZaloZNSRepository(Data.Context.Context context) : base(context)
        {
            _context = context;
        }
    }
}

