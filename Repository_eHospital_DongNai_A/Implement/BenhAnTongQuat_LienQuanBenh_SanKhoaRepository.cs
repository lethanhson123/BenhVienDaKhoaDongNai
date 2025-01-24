namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_LienQuanBenh_SanKhoaRepository : BaseRepository<BenhAnTongQuat_LienQuanBenh_SanKhoa>
    , IBenhAnTongQuat_LienQuanBenh_SanKhoaRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_LienQuanBenh_SanKhoaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

