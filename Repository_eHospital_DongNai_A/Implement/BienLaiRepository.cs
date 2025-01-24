namespace Repository_eHospital_DongNai_A.Implement
{
    public class BienLaiRepository : BaseRepository<BienLai>
    , IBienLaiRepository
    {
    private readonly Context _context;
    public BienLaiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

