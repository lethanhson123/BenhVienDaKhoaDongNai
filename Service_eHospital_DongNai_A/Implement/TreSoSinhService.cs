namespace Service_eHospital_DongNai_A.Implement
{
    public class TreSoSinhService : BaseService<TreSoSinh, ITreSoSinhRepository>
    , ITreSoSinhService
    {
    private readonly ITreSoSinhRepository _TreSoSinhRepository;
    public TreSoSinhService(ITreSoSinhRepository TreSoSinhRepository) : base(TreSoSinhRepository)
    {
    _TreSoSinhRepository = TreSoSinhRepository;
    }
    }
    }

