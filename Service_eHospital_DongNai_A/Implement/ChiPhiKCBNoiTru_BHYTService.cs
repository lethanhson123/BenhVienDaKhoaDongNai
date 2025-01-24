namespace Service_eHospital_DongNai_A.Implement
{
    public class ChiPhiKCBNoiTru_BHYTService : BaseService<ChiPhiKCBNoiTru_BHYT, IChiPhiKCBNoiTru_BHYTRepository>
    , IChiPhiKCBNoiTru_BHYTService
    {
    private readonly IChiPhiKCBNoiTru_BHYTRepository _ChiPhiKCBNoiTru_BHYTRepository;
    public ChiPhiKCBNoiTru_BHYTService(IChiPhiKCBNoiTru_BHYTRepository ChiPhiKCBNoiTru_BHYTRepository) : base(ChiPhiKCBNoiTru_BHYTRepository)
    {
    _ChiPhiKCBNoiTru_BHYTRepository = ChiPhiKCBNoiTru_BHYTRepository;
    }
    }
    }

