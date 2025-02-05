namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_LoaiTrucRepository : BaseRepository<NS_DM_LoaiTruc>
    , INS_DM_LoaiTrucRepository
    {
    private readonly Context _context;
    public NS_DM_LoaiTrucRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

