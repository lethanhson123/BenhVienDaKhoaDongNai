namespace Service_eHospital_DongNai_A.Implement
{
    public class ChayThanNhanTaoService : BaseService<ChayThanNhanTao, IChayThanNhanTaoRepository>
    , IChayThanNhanTaoService
    {
    private readonly IChayThanNhanTaoRepository _ChayThanNhanTaoRepository;
    public ChayThanNhanTaoService(IChayThanNhanTaoRepository ChayThanNhanTaoRepository) : base(ChayThanNhanTaoRepository)
    {
    _ChayThanNhanTaoRepository = ChayThanNhanTaoRepository;
    }
    }
    }

