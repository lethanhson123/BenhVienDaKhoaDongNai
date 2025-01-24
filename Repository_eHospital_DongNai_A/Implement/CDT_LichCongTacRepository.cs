namespace Repository_eHospital_DongNai_A.Implement
{
    public class CDT_LichCongTacRepository : BaseRepository<CDT_LichCongTac>
    , ICDT_LichCongTacRepository
    {
    private readonly Context _context;
    public CDT_LichCongTacRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

