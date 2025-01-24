namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GCSRepository : BaseRepository<BenhAnTongQuat_GCS>
    , IBenhAnTongQuat_GCSRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_GCSRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

