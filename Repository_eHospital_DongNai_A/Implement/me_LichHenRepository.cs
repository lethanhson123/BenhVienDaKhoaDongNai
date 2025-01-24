namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_LichHenRepository : BaseRepository<me_LichHen>
    , Ime_LichHenRepository
    {
    private readonly Context _context;
    public me_LichHenRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

