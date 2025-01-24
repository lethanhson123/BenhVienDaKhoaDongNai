namespace Repository_eHospital_DongNai_A.Implement
{
    public class me_KhuVucRepository : BaseRepository<me_KhuVuc>
    , Ime_KhuVucRepository
    {
    private readonly Context _context;
    public me_KhuVucRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

