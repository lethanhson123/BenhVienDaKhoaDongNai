namespace Service.Implement
{
    public class HRBangLuongChiTietService : BaseService<HRBangLuongChiTiet, IHRBangLuongChiTietRepository>
    , IHRBangLuongChiTietService
    {
    private readonly IHRBangLuongChiTietRepository _HRBangLuongChiTietRepository;
    public HRBangLuongChiTietService(IHRBangLuongChiTietRepository HRBangLuongChiTietRepository) : base(HRBangLuongChiTietRepository)
    {
    _HRBangLuongChiTietRepository = HRBangLuongChiTietRepository;
    }
    }
    }

