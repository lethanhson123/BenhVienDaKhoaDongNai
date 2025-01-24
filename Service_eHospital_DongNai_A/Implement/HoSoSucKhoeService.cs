namespace Service_eHospital_DongNai_A.Implement
{
    public class HoSoSucKhoeService : BaseService<HoSoSucKhoe, IHoSoSucKhoeRepository>
    , IHoSoSucKhoeService
    {
    private readonly IHoSoSucKhoeRepository _HoSoSucKhoeRepository;
    public HoSoSucKhoeService(IHoSoSucKhoeRepository HoSoSucKhoeRepository) : base(HoSoSucKhoeRepository)
    {
    _HoSoSucKhoeRepository = HoSoSucKhoeRepository;
    }
    }
    }

