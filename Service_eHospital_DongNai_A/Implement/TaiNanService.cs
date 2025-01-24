namespace Service_eHospital_DongNai_A.Implement
{
    public class TaiNanService : BaseService<TaiNan, ITaiNanRepository>
    , ITaiNanService
    {
    private readonly ITaiNanRepository _TaiNanRepository;
    public TaiNanService(ITaiNanRepository TaiNanRepository) : base(TaiNanRepository)
    {
    _TaiNanRepository = TaiNanRepository;
    }
    }
    }

