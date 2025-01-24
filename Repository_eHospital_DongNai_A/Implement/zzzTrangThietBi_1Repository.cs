namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzTrangThietBi_1Repository : BaseRepository<zzzTrangThietBi_1>
    , IzzzTrangThietBi_1Repository
    {
    private readonly Context _context;
    public zzzTrangThietBi_1Repository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

