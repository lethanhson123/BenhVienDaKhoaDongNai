namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAn_SaiGioService : BaseService<BenhAn_SaiGio, IBenhAn_SaiGioRepository>
    , IBenhAn_SaiGioService
    {
    private readonly IBenhAn_SaiGioRepository _BenhAn_SaiGioRepository;
    public BenhAn_SaiGioService(IBenhAn_SaiGioRepository BenhAn_SaiGioRepository) : base(BenhAn_SaiGioRepository)
    {
    _BenhAn_SaiGioRepository = BenhAn_SaiGioRepository;
    }
    }
    }

