namespace Service_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_TiepXucService : BaseService<HoSoSucKhoe_TiepXuc, IHoSoSucKhoe_TiepXucRepository>
    , IHoSoSucKhoe_TiepXucService
    {
    private readonly IHoSoSucKhoe_TiepXucRepository _HoSoSucKhoe_TiepXucRepository;
    public HoSoSucKhoe_TiepXucService(IHoSoSucKhoe_TiepXucRepository HoSoSucKhoe_TiepXucRepository) : base(HoSoSucKhoe_TiepXucRepository)
    {
    _HoSoSucKhoe_TiepXucRepository = HoSoSucKhoe_TiepXucRepository;
    }
    }
    }

