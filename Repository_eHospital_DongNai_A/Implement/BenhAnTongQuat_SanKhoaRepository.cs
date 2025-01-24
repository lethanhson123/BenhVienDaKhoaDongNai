namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_SanKhoaRepository : BaseRepository<BenhAnTongQuat_SanKhoa>
    , IBenhAnTongQuat_SanKhoaRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_SanKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

