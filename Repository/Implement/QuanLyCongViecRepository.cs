namespace Repository.Implement
{
    public class QuanLyCongViecRepository : BaseRepository<QuanLyCongViec>
    , IQuanLyCongViecRepository
    {
        private readonly Data.Context.Context _context;
        public QuanLyCongViecRepository(Data.Context.Context context) : base(context)
        {
            _context = context;
        }
    }
}

