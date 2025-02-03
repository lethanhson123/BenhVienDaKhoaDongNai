namespace Repository_eHospital_DongNai_A_Config.Implement
{
    public class testRepository : BaseRepository<test>
    , ItestRepository
    {
    private readonly Context _context;
    public testRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

