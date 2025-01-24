namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnNgoaiTruRepository : BaseRepository<BenhAnNgoaiTru>
    , IBenhAnNgoaiTruRepository
    {
    private readonly Context _context;
    public BenhAnNgoaiTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

