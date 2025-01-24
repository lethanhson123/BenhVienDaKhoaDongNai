namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_NhiKhoaRepository : BaseRepository<BenhAnTongQuat_NhiKhoa>
    , IBenhAnTongQuat_NhiKhoaRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_NhiKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

