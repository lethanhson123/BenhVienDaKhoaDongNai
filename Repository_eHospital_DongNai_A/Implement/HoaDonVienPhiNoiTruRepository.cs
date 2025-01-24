namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoaDonVienPhiNoiTruRepository : BaseRepository<HoaDonVienPhiNoiTru>
    , IHoaDonVienPhiNoiTruRepository
    {
    private readonly Context _context;
    public HoaDonVienPhiNoiTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

