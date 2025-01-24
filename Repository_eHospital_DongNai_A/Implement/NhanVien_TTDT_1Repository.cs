namespace Repository_eHospital_DongNai_A.Implement
{
    public class NhanVien_TTDT_1Repository : BaseRepository<NhanVien_TTDT_1>
    , INhanVien_TTDT_1Repository
    {
    private readonly Context _context;
    public NhanVien_TTDT_1Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

