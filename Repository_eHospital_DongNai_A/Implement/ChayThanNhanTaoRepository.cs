namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChayThanNhanTaoRepository : BaseRepository<ChayThanNhanTao>
    , IChayThanNhanTaoRepository
    {
    private readonly Context _context;
    public ChayThanNhanTaoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

