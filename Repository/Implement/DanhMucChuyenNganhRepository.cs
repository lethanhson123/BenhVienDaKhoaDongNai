namespace Repository.Implement
{
    public class DanhMucChuyenNganhRepository : BaseRepository<DanhMucChuyenNganh>
    , IDanhMucChuyenNganhRepository
    {
    private readonly Context _context;
    public DanhMucChuyenNganhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

