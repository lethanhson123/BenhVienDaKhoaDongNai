namespace Repository_eHospital_DongNai_A.Implement
{
    public class MienGiamRepository : BaseRepository<MienGiam>
    , IMienGiamRepository
    {
    private readonly Context _context;
    public MienGiamRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

