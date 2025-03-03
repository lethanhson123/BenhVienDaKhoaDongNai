namespace Repository.Implement
{
    public class DanhMucToChucDaoTaoRepository : BaseRepository<DanhMucToChucDaoTao>
    , IDanhMucToChucDaoTaoRepository
    {
    private readonly Context _context;
    public DanhMucToChucDaoTaoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

