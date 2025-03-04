namespace Service.Implement
{
    public class HRNhanVienBangCapService : BaseService<HRNhanVienBangCap, IHRNhanVienBangCapRepository>
    , IHRNhanVienBangCapService
    {
    private readonly IHRNhanVienBangCapRepository _HRNhanVienBangCapRepository;
    public HRNhanVienBangCapService(IHRNhanVienBangCapRepository HRNhanVienBangCapRepository) : base(HRNhanVienBangCapRepository)
    {
    _HRNhanVienBangCapRepository = HRNhanVienBangCapRepository;
    }
    }
    }

