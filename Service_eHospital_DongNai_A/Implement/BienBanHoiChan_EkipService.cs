namespace Service_eHospital_DongNai_A.Implement
{
    public class BienBanHoiChan_EkipService : BaseService<BienBanHoiChan_Ekip, IBienBanHoiChan_EkipRepository>
    , IBienBanHoiChan_EkipService
    {
    private readonly IBienBanHoiChan_EkipRepository _BienBanHoiChan_EkipRepository;
    public BienBanHoiChan_EkipService(IBienBanHoiChan_EkipRepository BienBanHoiChan_EkipRepository) : base(BienBanHoiChan_EkipRepository)
    {
    _BienBanHoiChan_EkipRepository = BienBanHoiChan_EkipRepository;
    }
    }
    }

