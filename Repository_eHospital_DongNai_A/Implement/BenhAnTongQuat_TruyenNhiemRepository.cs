namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TruyenNhiemRepository : BaseRepository<BenhAnTongQuat_TruyenNhiem>
    , IBenhAnTongQuat_TruyenNhiemRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_TruyenNhiemRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

