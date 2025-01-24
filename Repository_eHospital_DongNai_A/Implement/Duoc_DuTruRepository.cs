namespace Repository_eHospital_DongNai_A.Implement
{
    public class Duoc_DuTruRepository : BaseRepository<Duoc_DuTru>
    , IDuoc_DuTruRepository
    {
    private readonly Context _context;
    public Duoc_DuTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

