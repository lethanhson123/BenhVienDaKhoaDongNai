namespace Repository_eHospital_DongNai_A.Implement
{
    public class TonKhoRepository : BaseRepository<TonKho>
    , ITonKhoRepository
    {
    private readonly Context _context;
    public TonKhoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

