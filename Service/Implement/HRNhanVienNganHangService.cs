namespace Service.Implement
{
    public class HRNhanVienNganHangService : BaseService<HRNhanVienNganHang, IHRNhanVienNganHangRepository>
    , IHRNhanVienNganHangService
    {
    private readonly IHRNhanVienNganHangRepository _HRNhanVienNganHangRepository;
    public HRNhanVienNganHangService(IHRNhanVienNganHangRepository HRNhanVienNganHangRepository) : base(HRNhanVienNganHangRepository)
    {
    _HRNhanVienNganHangRepository = HRNhanVienNganHangRepository;
    }
    }
    }

