namespace Repository_eHospital_DongNai_A.Implement
{
    public class NghiPhepRepository : BaseRepository<NghiPhep>
    , INghiPhepRepository
    {
    private readonly Context _context;
    public NghiPhepRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

