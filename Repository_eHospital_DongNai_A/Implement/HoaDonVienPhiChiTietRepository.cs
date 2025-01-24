namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoaDonVienPhiChiTietRepository : BaseRepository<HoaDonVienPhiChiTiet>
    , IHoaDonVienPhiChiTietRepository
    {
    private readonly Context _context;
    public HoaDonVienPhiChiTietRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

