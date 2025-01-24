namespace Repository_eHospital_DongNai_A.Implement
{
    public class BenhAnNhiemKhuanRepository : BaseRepository<BenhAnNhiemKhuan>
    , IBenhAnNhiemKhuanRepository
    {
    private readonly Context _context;
    public BenhAnNhiemKhuanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

