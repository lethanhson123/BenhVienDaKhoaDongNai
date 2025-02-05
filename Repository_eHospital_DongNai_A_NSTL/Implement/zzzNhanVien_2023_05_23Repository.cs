namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class zzzNhanVien_2023_05_23Repository : BaseRepository<zzzNhanVien_2023_05_23>
    , IzzzNhanVien_2023_05_23Repository
    {
    private readonly Context _context;
    public zzzNhanVien_2023_05_23Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

