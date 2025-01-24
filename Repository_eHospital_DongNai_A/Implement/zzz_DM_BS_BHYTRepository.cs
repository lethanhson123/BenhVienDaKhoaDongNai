namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzz_DM_BS_BHYTRepository : BaseRepository<zzz_DM_BS_BHYT>
    , Izzz_DM_BS_BHYTRepository
    {
    private readonly Context _context;
    public zzz_DM_BS_BHYTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

