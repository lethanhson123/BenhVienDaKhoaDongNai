namespace Service_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_DinhKyService : BaseService<HoSoSucKhoe_DinhKy, IHoSoSucKhoe_DinhKyRepository>
    , IHoSoSucKhoe_DinhKyService
    {
    private readonly IHoSoSucKhoe_DinhKyRepository _HoSoSucKhoe_DinhKyRepository;
    public HoSoSucKhoe_DinhKyService(IHoSoSucKhoe_DinhKyRepository HoSoSucKhoe_DinhKyRepository) : base(HoSoSucKhoe_DinhKyRepository)
    {
    _HoSoSucKhoe_DinhKyRepository = HoSoSucKhoe_DinhKyRepository;
    }
    }
    }

