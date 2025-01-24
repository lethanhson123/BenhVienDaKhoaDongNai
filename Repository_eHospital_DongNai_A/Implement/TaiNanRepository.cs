namespace Repository_eHospital_DongNai_A.Implement
{
    public class TaiNanRepository : BaseRepository<TaiNan>
    , ITaiNanRepository
    {
    private readonly Context _context;
    public TaiNanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

