namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzThietBi_4Repository : BaseRepository<zzzThietBi_4>
    , IzzzThietBi_4Repository
    {
    private readonly Context _context;
    public zzzThietBi_4Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

