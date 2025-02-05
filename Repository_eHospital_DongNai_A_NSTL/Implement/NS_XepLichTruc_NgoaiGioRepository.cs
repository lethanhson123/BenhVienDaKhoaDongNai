namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_XepLichTruc_NgoaiGioRepository : BaseRepository<NS_XepLichTruc_NgoaiGio>
    , INS_XepLichTruc_NgoaiGioRepository
    {
    private readonly Context _context;
    public NS_XepLichTruc_NgoaiGioRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

