namespace Repository_eHospital_DongNai_A.Implement
{
    public class ChandoanRepository : BaseRepository<Chandoan>
    , IChandoanRepository
    {
    private readonly Context _context;
    public ChandoanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

