namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_SoSinhRepository : BaseRepository<BenhAnTongQuat_SoSinh>
    , IBenhAnTongQuat_SoSinhRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_SoSinhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

