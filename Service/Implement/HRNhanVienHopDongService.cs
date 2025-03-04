namespace Service.Implement
{
    public class HRNhanVienHopDongService : BaseService<HRNhanVienHopDong, IHRNhanVienHopDongRepository>
    , IHRNhanVienHopDongService
    {
    private readonly IHRNhanVienHopDongRepository _HRNhanVienHopDongRepository;
    public HRNhanVienHopDongService(IHRNhanVienHopDongRepository HRNhanVienHopDongRepository) : base(HRNhanVienHopDongRepository)
    {
    _HRNhanVienHopDongRepository = HRNhanVienHopDongRepository;
    }
    }
    }

