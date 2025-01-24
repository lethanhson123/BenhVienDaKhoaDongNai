namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_NgoaiKhoaRepository : BaseRepository<BenhAnTongQuat_NgoaiKhoa>
    , IBenhAnTongQuat_NgoaiKhoaRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_NgoaiKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

