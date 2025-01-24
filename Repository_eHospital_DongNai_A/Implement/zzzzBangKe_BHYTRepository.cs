namespace Repository_eHospital_DongNai_A.Implement
{
    public class zzzzBangKe_BHYTRepository : BaseRepository<zzzzBangKe_BHYT>
    , IzzzzBangKe_BHYTRepository
    {
    private readonly Context _context;
    public zzzzBangKe_BHYTRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

