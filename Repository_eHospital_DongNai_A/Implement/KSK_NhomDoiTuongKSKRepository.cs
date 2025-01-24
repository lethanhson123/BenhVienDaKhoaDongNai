namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_NhomDoiTuongKSKRepository : BaseRepository<KSK_NhomDoiTuongKSK>
    , IKSK_NhomDoiTuongKSKRepository
    {
    private readonly Context _context;
    public KSK_NhomDoiTuongKSKRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

