namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuSoLoNhapService : BaseService<ChungTuSoLoNhap, IChungTuSoLoNhapRepository>
    , IChungTuSoLoNhapService
    {
    private readonly IChungTuSoLoNhapRepository _ChungTuSoLoNhapRepository;
    public ChungTuSoLoNhapService(IChungTuSoLoNhapRepository ChungTuSoLoNhapRepository) : base(ChungTuSoLoNhapRepository)
    {
    _ChungTuSoLoNhapRepository = ChungTuSoLoNhapRepository;
    }
    }
    }

