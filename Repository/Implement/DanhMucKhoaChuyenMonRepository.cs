namespace Repository.Implement
{
    public class DanhMucKhoaChuyenMonRepository : BaseRepository<DanhMucKhoaChuyenMon>
    , IDanhMucKhoaChuyenMonRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucKhoaChuyenMonRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

