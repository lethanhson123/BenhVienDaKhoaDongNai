namespace Service.Implement
{
    public class HRNhanVienThanhVienService : BaseService<HRNhanVienThanhVien, IHRNhanVienThanhVienRepository>
    , IHRNhanVienThanhVienService
    {
    private readonly IHRNhanVienThanhVienRepository _HRNhanVienThanhVienRepository;
    public HRNhanVienThanhVienService(IHRNhanVienThanhVienRepository HRNhanVienThanhVienRepository) : base(HRNhanVienThanhVienRepository)
    {
    _HRNhanVienThanhVienRepository = HRNhanVienThanhVienRepository;
    }
    }
    }

