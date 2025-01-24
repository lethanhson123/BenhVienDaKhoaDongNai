namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuChiPhiService : BaseService<ChungTuChiPhi, IChungTuChiPhiRepository>
    , IChungTuChiPhiService
    {
    private readonly IChungTuChiPhiRepository _ChungTuChiPhiRepository;
    public ChungTuChiPhiService(IChungTuChiPhiRepository ChungTuChiPhiRepository) : base(ChungTuChiPhiRepository)
    {
    _ChungTuChiPhiRepository = ChungTuChiPhiRepository;
    }
    }
    }

