namespace Service.Implement
{
    public class HRNhanVienService : BaseService<HRNhanVien, IHRNhanVienRepository>
    , IHRNhanVienService
    {
    private readonly IHRNhanVienRepository _HRNhanVienRepository;
    public HRNhanVienService(IHRNhanVienRepository HRNhanVienRepository) : base(HRNhanVienRepository)
    {
    _HRNhanVienRepository = HRNhanVienRepository;
    }
    }
    }

