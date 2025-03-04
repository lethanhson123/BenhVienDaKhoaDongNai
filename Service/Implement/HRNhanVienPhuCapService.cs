namespace Service.Implement
{
    public class HRNhanVienPhuCapService : BaseService<HRNhanVienPhuCap, IHRNhanVienPhuCapRepository>
    , IHRNhanVienPhuCapService
    {
    private readonly IHRNhanVienPhuCapRepository _HRNhanVienPhuCapRepository;
    public HRNhanVienPhuCapService(IHRNhanVienPhuCapRepository HRNhanVienPhuCapRepository) : base(HRNhanVienPhuCapRepository)
    {
    _HRNhanVienPhuCapRepository = HRNhanVienPhuCapRepository;
    }
    }
    }

