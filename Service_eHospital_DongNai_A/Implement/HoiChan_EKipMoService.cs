namespace Service_eHospital_DongNai_A.Implement
{
    public class HoiChan_EKipMoService : BaseService<HoiChan_EKipMo, IHoiChan_EKipMoRepository>
    , IHoiChan_EKipMoService
    {
    private readonly IHoiChan_EKipMoRepository _HoiChan_EKipMoRepository;
    public HoiChan_EKipMoService(IHoiChan_EKipMoRepository HoiChan_EKipMoRepository) : base(HoiChan_EKipMoRepository)
    {
    _HoiChan_EKipMoRepository = HoiChan_EKipMoRepository;
    }
    }
    }

