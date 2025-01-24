namespace Repository_eHospital_DongNai_A.Implement
{
    public class DangKyHoaDonVATRepository : BaseRepository<DangKyHoaDonVAT>
    , IDangKyHoaDonVATRepository
    {
    private readonly Context _context;
    public DangKyHoaDonVATRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

