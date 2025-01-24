namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChanDoanTeBaoHocCoTuCungAmDaoRepository : BaseRepository<ChanDoanTeBaoHocCoTuCungAmDao>
    , IChanDoanTeBaoHocCoTuCungAmDaoRepository
    {
    private readonly Context _context;
    public ChanDoanTeBaoHocCoTuCungAmDaoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

