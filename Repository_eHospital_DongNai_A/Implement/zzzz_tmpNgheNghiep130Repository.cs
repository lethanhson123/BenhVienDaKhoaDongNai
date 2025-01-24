namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzz_tmpNgheNghiep130Repository : BaseRepository<zzzz_tmpNgheNghiep130>
    , Izzzz_tmpNgheNghiep130Repository
    {
    private readonly Context _context;
    public zzzz_tmpNgheNghiep130Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

