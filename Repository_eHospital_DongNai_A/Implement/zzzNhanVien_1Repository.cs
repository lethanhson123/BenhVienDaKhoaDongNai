namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzNhanVien_1Repository : BaseRepository<zzzNhanVien_1>
    , IzzzNhanVien_1Repository
    {
    private readonly Context _context;
    public zzzNhanVien_1Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

