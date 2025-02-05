namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_KhoaBangChamCongRepository : BaseRepository<NS_KhoaBangChamCong>
    , INS_KhoaBangChamCongRepository
    {
    private readonly Context _context;
    public NS_KhoaBangChamCongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

