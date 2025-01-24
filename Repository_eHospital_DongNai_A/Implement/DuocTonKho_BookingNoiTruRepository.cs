namespace Repository_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_BookingNoiTruRepository : BaseRepository<DuocTonKho_BookingNoiTru>
    , IDuocTonKho_BookingNoiTruRepository
    {
    private readonly Context _context;
    public DuocTonKho_BookingNoiTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

