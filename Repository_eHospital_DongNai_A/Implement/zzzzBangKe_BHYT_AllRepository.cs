namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzzBangKe_BHYT_AllRepository : BaseRepository<zzzzBangKe_BHYT_All>
    , IzzzzBangKe_BHYT_AllRepository
    {
    private readonly Context _context;
    public zzzzBangKe_BHYT_AllRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

