namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TongKet_PhauThuatRepository : BaseRepository<BenhAnTongQuat_TongKet_PhauThuat>
    , IBenhAnTongQuat_TongKet_PhauThuatRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_TongKet_PhauThuatRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

