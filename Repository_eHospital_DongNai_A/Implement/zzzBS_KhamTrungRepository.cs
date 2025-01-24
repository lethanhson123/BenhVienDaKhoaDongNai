namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzBS_KhamTrungRepository : BaseRepository<zzzBS_KhamTrung>
    , IzzzBS_KhamTrungRepository
    {
    private readonly Context _context;
    public zzzBS_KhamTrungRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

