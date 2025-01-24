namespace Service_eHospital_DongNai_A.Implement
{
    public class BHYT_KiemTraService : BaseService<BHYT_KiemTra, IBHYT_KiemTraRepository>
    , IBHYT_KiemTraService
    {
    private readonly IBHYT_KiemTraRepository _BHYT_KiemTraRepository;
    public BHYT_KiemTraService(IBHYT_KiemTraRepository BHYT_KiemTraRepository) : base(BHYT_KiemTraRepository)
    {
    _BHYT_KiemTraRepository = BHYT_KiemTraRepository;
    }
    }
    }

