namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_DM_BieuThueTNCNRepository : BaseRepository<NS_DM_BieuThueTNCN>
    , INS_DM_BieuThueTNCNRepository
    {
    private readonly Context _context;
    public NS_DM_BieuThueTNCNRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

