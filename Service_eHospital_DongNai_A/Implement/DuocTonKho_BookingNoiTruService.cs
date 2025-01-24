namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_BookingNoiTruService : BaseService<DuocTonKho_BookingNoiTru, IDuocTonKho_BookingNoiTruRepository>
    , IDuocTonKho_BookingNoiTruService
    {
    private readonly IDuocTonKho_BookingNoiTruRepository _DuocTonKho_BookingNoiTruRepository;
    public DuocTonKho_BookingNoiTruService(IDuocTonKho_BookingNoiTruRepository DuocTonKho_BookingNoiTruRepository) : base(DuocTonKho_BookingNoiTruRepository)
    {
    _DuocTonKho_BookingNoiTruRepository = DuocTonKho_BookingNoiTruRepository;
    }
    }
    }

