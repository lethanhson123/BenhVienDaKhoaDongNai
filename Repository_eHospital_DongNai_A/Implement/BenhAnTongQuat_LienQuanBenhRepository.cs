namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_LienQuanBenhRepository : BaseRepository<BenhAnTongQuat_LienQuanBenh>
    , IBenhAnTongQuat_LienQuanBenhRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_LienQuanBenhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

