namespace Service_eHospital_DongNai_A.Implement
{
    public class BienBanHoiChanService : BaseService<BienBanHoiChan, IBienBanHoiChanRepository>
    , IBienBanHoiChanService
    {
    private readonly IBienBanHoiChanRepository _BienBanHoiChanRepository;
    public BienBanHoiChanService(IBienBanHoiChanRepository BienBanHoiChanRepository) : base(BienBanHoiChanRepository)
    {
    _BienBanHoiChanRepository = BienBanHoiChanRepository;
    }
    }
    }

