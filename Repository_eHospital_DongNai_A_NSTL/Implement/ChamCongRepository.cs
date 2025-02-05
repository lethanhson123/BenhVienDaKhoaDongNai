namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class ChamCongRepository : BaseRepository<ChamCong>
    , IChamCongRepository
    {
    private readonly Context _context;
    public ChamCongRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

