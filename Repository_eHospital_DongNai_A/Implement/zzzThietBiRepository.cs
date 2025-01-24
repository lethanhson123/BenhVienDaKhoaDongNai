namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzThietBiRepository : BaseRepository<zzzThietBi>
    , IzzzThietBiRepository
    {
    private readonly Context _context;
    public zzzThietBiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

