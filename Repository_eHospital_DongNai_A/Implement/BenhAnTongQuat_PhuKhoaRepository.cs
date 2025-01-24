namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_PhuKhoaRepository : BaseRepository<BenhAnTongQuat_PhuKhoa>
    , IBenhAnTongQuat_PhuKhoaRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_PhuKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

