namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_NoiKhoaRepository : BaseRepository<BenhAnTongQuat_NoiKhoa>
    , IBenhAnTongQuat_NoiKhoaRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_NoiKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

