namespace Service_eHospital_DongNai_A.Implement
{
    public class TonKhoService : BaseService<TonKho, ITonKhoRepository>
    , ITonKhoService
    {
    private readonly ITonKhoRepository _TonKhoRepository;
    public TonKhoService(ITonKhoRepository TonKhoRepository) : base(TonKhoRepository)
    {
    _TonKhoRepository = TonKhoRepository;
    }
    }
    }

