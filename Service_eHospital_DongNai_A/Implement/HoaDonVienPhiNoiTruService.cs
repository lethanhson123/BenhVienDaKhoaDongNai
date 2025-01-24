namespace Service_eHospital_DongNai_A.Implement
{
    public class HoaDonVienPhiNoiTruService : BaseService<HoaDonVienPhiNoiTru, IHoaDonVienPhiNoiTruRepository>
    , IHoaDonVienPhiNoiTruService
    {
    private readonly IHoaDonVienPhiNoiTruRepository _HoaDonVienPhiNoiTruRepository;
    public HoaDonVienPhiNoiTruService(IHoaDonVienPhiNoiTruRepository HoaDonVienPhiNoiTruRepository) : base(HoaDonVienPhiNoiTruRepository)
    {
    _HoaDonVienPhiNoiTruRepository = HoaDonVienPhiNoiTruRepository;
    }
    }
    }

