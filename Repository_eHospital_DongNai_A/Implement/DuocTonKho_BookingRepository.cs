namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_BookingRepository : BaseRepository<DuocTonKho_Booking>
    , IDuocTonKho_BookingRepository
    {
    private readonly Context _context;
    public DuocTonKho_BookingRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

