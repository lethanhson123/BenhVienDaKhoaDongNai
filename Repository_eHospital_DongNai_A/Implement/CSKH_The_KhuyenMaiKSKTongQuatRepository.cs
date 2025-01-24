namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_KhuyenMaiKSKTongQuatRepository : BaseRepository<CSKH_The_KhuyenMaiKSKTongQuat>
    , ICSKH_The_KhuyenMaiKSKTongQuatRepository
    {
    private readonly Context _context;
    public CSKH_The_KhuyenMaiKSKTongQuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

