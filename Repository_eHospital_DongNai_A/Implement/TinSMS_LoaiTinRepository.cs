namespace Repository_eHospital_DongNai_A.Implement
{
    public class TinSMS_LoaiTinRepository : BaseRepository<TinSMS_LoaiTin>
    , ITinSMS_LoaiTinRepository
    {
    private readonly Context _context;
    public TinSMS_LoaiTinRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

