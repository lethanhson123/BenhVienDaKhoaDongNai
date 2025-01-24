namespace Service_eHospital_DongNai_A.Implement
{
    public class ChiPhiKCBNgoaiTru_BHYTService : BaseService<ChiPhiKCBNgoaiTru_BHYT, IChiPhiKCBNgoaiTru_BHYTRepository>
    , IChiPhiKCBNgoaiTru_BHYTService
    {
    private readonly IChiPhiKCBNgoaiTru_BHYTRepository _ChiPhiKCBNgoaiTru_BHYTRepository;
    public ChiPhiKCBNgoaiTru_BHYTService(IChiPhiKCBNgoaiTru_BHYTRepository ChiPhiKCBNgoaiTru_BHYTRepository) : base(ChiPhiKCBNgoaiTru_BHYTRepository)
    {
    _ChiPhiKCBNgoaiTru_BHYTRepository = ChiPhiKCBNgoaiTru_BHYTRepository;
    }
    }
    }

