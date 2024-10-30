namespace Repository.Implement
{
    public class DanhMucHinhThucThanhToanRepository : BaseRepository<DanhMucHinhThucThanhToan>
    , IDanhMucHinhThucThanhToanRepository
    {
    private readonly Data.Context.Context _context;
    public DanhMucHinhThucThanhToanRepository(Data.Context.Context context) : base(context)
    {
    _context = context;
    }
    }
    }

