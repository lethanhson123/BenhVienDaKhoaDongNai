namespace Repository.Implement
{
    public class DanhMucGiamTruRepository : BaseRepository<DanhMucGiamTru>
    , IDanhMucGiamTruRepository
    {
    private readonly Context _context;
    public DanhMucGiamTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

