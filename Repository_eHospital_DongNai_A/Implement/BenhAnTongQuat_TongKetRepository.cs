namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TongKetRepository : BaseRepository<BenhAnTongQuat_TongKet>
    , IBenhAnTongQuat_TongKetRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_TongKetRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

