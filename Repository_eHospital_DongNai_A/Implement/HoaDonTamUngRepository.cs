namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoaDonTamUngRepository : BaseRepository<HoaDonTamUng>
    , IHoaDonTamUngRepository
    {
    private readonly Context _context;
    public HoaDonTamUngRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

