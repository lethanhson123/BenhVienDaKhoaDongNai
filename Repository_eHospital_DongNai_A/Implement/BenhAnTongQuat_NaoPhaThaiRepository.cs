namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_NaoPhaThaiRepository : BaseRepository<BenhAnTongQuat_NaoPhaThai>
    , IBenhAnTongQuat_NaoPhaThaiRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_NaoPhaThaiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

