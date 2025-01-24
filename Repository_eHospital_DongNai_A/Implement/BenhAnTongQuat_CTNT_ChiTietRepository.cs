namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_CTNT_ChiTietRepository : BaseRepository<BenhAnTongQuat_CTNT_ChiTiet>
    , IBenhAnTongQuat_CTNT_ChiTietRepository
    {
    private readonly Context _context;
    public BenhAnTongQuat_CTNT_ChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

