namespace Service_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoe_TiemChungService : BaseService<HoSoSucKhoe_TiemChung, IHoSoSucKhoe_TiemChungRepository>
    , IHoSoSucKhoe_TiemChungService
    {
    private readonly IHoSoSucKhoe_TiemChungRepository _HoSoSucKhoe_TiemChungRepository;
    public HoSoSucKhoe_TiemChungService(IHoSoSucKhoe_TiemChungRepository HoSoSucKhoe_TiemChungRepository) : base(HoSoSucKhoe_TiemChungRepository)
    {
    _HoSoSucKhoe_TiemChungRepository = HoSoSucKhoe_TiemChungRepository;
    }
    }
    }

