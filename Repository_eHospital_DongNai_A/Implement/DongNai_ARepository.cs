namespace Repository_eHospital_DongNai_A.Implement
{
    public class DongNai_ARepository : BaseRepository<DongNai_A>
    , IDongNai_ARepository
    {
    private readonly Context _context;
    public DongNai_ARepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

