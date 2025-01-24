namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhNhan_HinhAnhService : BaseService<BenhNhan_HinhAnh, IBenhNhan_HinhAnhRepository>
    , IBenhNhan_HinhAnhService
    {
    private readonly IBenhNhan_HinhAnhRepository _BenhNhan_HinhAnhRepository;
    public BenhNhan_HinhAnhService(IBenhNhan_HinhAnhRepository BenhNhan_HinhAnhRepository) : base(BenhNhan_HinhAnhRepository)
    {
    _BenhNhan_HinhAnhRepository = BenhNhan_HinhAnhRepository;
    }
    }
    }

