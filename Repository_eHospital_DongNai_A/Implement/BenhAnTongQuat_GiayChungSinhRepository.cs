namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GiayChungSinhRepository : BaseRepository<BenhAnTongQuat_GiayChungSinh>
    , IBenhAnTongQuat_GiayChungSinhRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_GiayChungSinhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

