namespace Repository_eHospital_DongNai_A.Implement
{
    public class ComputerNameRepository : BaseRepository<ComputerName>
    , IComputerNameRepository
    {
    private readonly Context _context;
    public ComputerNameRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

