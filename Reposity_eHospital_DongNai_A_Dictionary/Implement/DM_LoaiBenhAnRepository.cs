namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_LoaiBenhAnRepository : BaseRepository<DM_LoaiBenhAn>
    , IDM_LoaiBenhAnRepository
    {
    private readonly Context _context;
    public DM_LoaiBenhAnRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

