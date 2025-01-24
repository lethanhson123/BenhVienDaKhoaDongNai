namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuPhanBoChiPhiService : BaseService<ChungTuPhanBoChiPhi, IChungTuPhanBoChiPhiRepository>
    , IChungTuPhanBoChiPhiService
    {
    private readonly IChungTuPhanBoChiPhiRepository _ChungTuPhanBoChiPhiRepository;
    public ChungTuPhanBoChiPhiService(IChungTuPhanBoChiPhiRepository ChungTuPhanBoChiPhiRepository) : base(ChungTuPhanBoChiPhiRepository)
    {
    _ChungTuPhanBoChiPhiRepository = ChungTuPhanBoChiPhiRepository;
    }
    }
    }

