namespace Repository_eHospital_DongNai_A.Implement
{
    public class QuanLyBenhPham_YeuCauRepository : BaseRepository<QuanLyBenhPham_YeuCau>
    , IQuanLyBenhPham_YeuCauRepository
    {
    private readonly Context _context;
    public QuanLyBenhPham_YeuCauRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

