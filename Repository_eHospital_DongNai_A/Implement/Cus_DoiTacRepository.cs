namespace Repository_eHospital_DongNai_A.Implement
{
    public class Cus_DoiTacRepository : BaseRepository<Cus_DoiTac>
    , ICus_DoiTacRepository
    {
    private readonly Context _context;
    public Cus_DoiTacRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

