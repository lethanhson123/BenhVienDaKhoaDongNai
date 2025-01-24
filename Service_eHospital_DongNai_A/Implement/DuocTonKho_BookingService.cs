namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_BookingService : BaseService<DuocTonKho_Booking, IDuocTonKho_BookingRepository>
    , IDuocTonKho_BookingService
    {
    private readonly IDuocTonKho_BookingRepository _DuocTonKho_BookingRepository;
    public DuocTonKho_BookingService(IDuocTonKho_BookingRepository DuocTonKho_BookingRepository) : base(DuocTonKho_BookingRepository)
    {
    _DuocTonKho_BookingRepository = DuocTonKho_BookingRepository;
    }
    }
    }

