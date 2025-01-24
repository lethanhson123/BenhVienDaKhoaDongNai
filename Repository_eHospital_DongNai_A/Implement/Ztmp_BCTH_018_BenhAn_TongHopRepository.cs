namespace Repository_eHospital_DongNai_A.Implement
{
    public class Ztmp_BCTH_018_BenhAn_TongHopRepository : BaseRepository<Ztmp_BCTH_018_BenhAn_TongHop>
    , IZtmp_BCTH_018_BenhAn_TongHopRepository
    {
    private readonly Context _context;
    public Ztmp_BCTH_018_BenhAn_TongHopRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

