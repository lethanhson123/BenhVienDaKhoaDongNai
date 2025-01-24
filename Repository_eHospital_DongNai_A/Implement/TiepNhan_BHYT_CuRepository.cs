namespace Repository_eHospital_DongNai_A.Implement
{
    public class TiepNhan_BHYT_CuRepository : BaseRepository<TiepNhan_BHYT_Cu>
    , ITiepNhan_BHYT_CuRepository
    {
    private readonly Context _context;
    public TiepNhan_BHYT_CuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

