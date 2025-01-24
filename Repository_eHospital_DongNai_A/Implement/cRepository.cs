namespace Repository_eHospital_DongNai_A.Implement
{
    public class cRepository : BaseRepository<c>
    , IcRepository
    {
    private readonly Context _context;
    public cRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

