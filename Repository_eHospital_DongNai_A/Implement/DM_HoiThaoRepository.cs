namespace Repository_eHospital_DongNai_A.Implement
{
    public class DM_HoiThaoRepository : BaseRepository<DM_HoiThao>
    , IDM_HoiThaoRepository
    {
    private readonly Context _context;
    public DM_HoiThaoRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

