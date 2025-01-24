namespace Repository_eHospital_DongNai_A.Implement
{
    public class zz_HDDT_TempRepository : BaseRepository<zz_HDDT_Temp>
    , Izz_HDDT_TempRepository
    {
    private readonly Context _context;
    public zz_HDDT_TempRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

