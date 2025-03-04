namespace Service.Implement
{
    public class HRChamCongChiTietService : BaseService<HRChamCongChiTiet, IHRChamCongChiTietRepository>
    , IHRChamCongChiTietService
    {
    private readonly IHRChamCongChiTietRepository _HRChamCongChiTietRepository;
    public HRChamCongChiTietService(IHRChamCongChiTietRepository HRChamCongChiTietRepository) : base(HRChamCongChiTietRepository)
    {
    _HRChamCongChiTietRepository = HRChamCongChiTietRepository;
    }
    }
    }

