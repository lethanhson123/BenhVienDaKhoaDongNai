namespace Repository_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_KHENTHUONGKYLUATRepository : BaseRepository<NS_KHENTHUONGKYLUAT>
    , INS_KHENTHUONGKYLUATRepository
    {
    private readonly Context _context;
    public NS_KHENTHUONGKYLUATRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

