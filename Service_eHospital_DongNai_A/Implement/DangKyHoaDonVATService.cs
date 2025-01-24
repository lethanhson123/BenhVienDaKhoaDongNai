namespace Service_eHospital_DongNai_A.Implement
{
    public class DangKyHoaDonVATService : BaseService<DangKyHoaDonVAT, IDangKyHoaDonVATRepository>
    , IDangKyHoaDonVATService
    {
    private readonly IDangKyHoaDonVATRepository _DangKyHoaDonVATRepository;
    public DangKyHoaDonVATService(IDangKyHoaDonVATRepository DangKyHoaDonVATRepository) : base(DangKyHoaDonVATRepository)
    {
    _DangKyHoaDonVATRepository = DangKyHoaDonVATRepository;
    }
    }
    }

