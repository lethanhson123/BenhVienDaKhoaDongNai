namespace Service.Implement
{
    public class HRLichCongTacChiTietService : BaseService<HRLichCongTacChiTiet, IHRLichCongTacChiTietRepository>
    , IHRLichCongTacChiTietService
    {
    private readonly IHRLichCongTacChiTietRepository _HRLichCongTacChiTietRepository;
    public HRLichCongTacChiTietService(IHRLichCongTacChiTietRepository HRLichCongTacChiTietRepository) : base(HRLichCongTacChiTietRepository)
    {
    _HRLichCongTacChiTietRepository = HRLichCongTacChiTietRepository;
    }
    }
    }

