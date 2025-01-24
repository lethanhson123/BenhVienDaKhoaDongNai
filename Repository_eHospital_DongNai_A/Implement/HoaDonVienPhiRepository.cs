namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoaDonVienPhiRepository : BaseRepository<HoaDonVienPhi>
    , IHoaDonVienPhiRepository
    {
    private readonly Context _context;
    public HoaDonVienPhiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

