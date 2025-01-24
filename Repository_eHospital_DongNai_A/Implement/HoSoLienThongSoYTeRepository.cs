namespace Repository_eHospital_DongNai_A.Implement
{
    public class HoSoLienThongSoYTeRepository : BaseRepository<HoSoLienThongSoYTe>
    , IHoSoLienThongSoYTeRepository
    {
    private readonly Context _context;
    public HoSoLienThongSoYTeRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

