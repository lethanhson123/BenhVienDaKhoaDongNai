namespace Service_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_TienSuBanThanService : BaseService<HoSoSucKhoe_TienSuBanThan, IHoSoSucKhoe_TienSuBanThanRepository>
    , IHoSoSucKhoe_TienSuBanThanService
    {
    private readonly IHoSoSucKhoe_TienSuBanThanRepository _HoSoSucKhoe_TienSuBanThanRepository;
    public HoSoSucKhoe_TienSuBanThanService(IHoSoSucKhoe_TienSuBanThanRepository HoSoSucKhoe_TienSuBanThanRepository) : base(HoSoSucKhoe_TienSuBanThanRepository)
    {
    _HoSoSucKhoe_TienSuBanThanRepository = HoSoSucKhoe_TienSuBanThanRepository;
    }
    }
    }

