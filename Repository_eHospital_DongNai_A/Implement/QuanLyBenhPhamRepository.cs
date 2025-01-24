namespace Repository_eHospital_DongNai_A.Implement
{
    public class QuanLyBenhPhamRepository : BaseRepository<QuanLyBenhPham>
    , IQuanLyBenhPhamRepository
    {
    private readonly Context _context;
    public QuanLyBenhPhamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

