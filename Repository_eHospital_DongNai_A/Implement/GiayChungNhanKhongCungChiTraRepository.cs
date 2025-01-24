namespace Repository_eHospital_DongNai_A.Implement
{
    public class GiayChungNhanKhongCungChiTraRepository : BaseRepository<GiayChungNhanKhongCungChiTra>
    , IGiayChungNhanKhongCungChiTraRepository
    {
    private readonly Context _context;
    public GiayChungNhanKhongCungChiTraRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

