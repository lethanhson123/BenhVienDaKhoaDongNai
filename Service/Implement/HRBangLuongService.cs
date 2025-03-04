namespace Service.Implement
{
    public class HRBangLuongService : BaseService<HRBangLuong, IHRBangLuongRepository>
    , IHRBangLuongService
    {
    private readonly IHRBangLuongRepository _HRBangLuongRepository;
    public HRBangLuongService(IHRBangLuongRepository HRBangLuongRepository) : base(HRBangLuongRepository)
    {
    _HRBangLuongRepository = HRBangLuongRepository;
    }
    }
    }

