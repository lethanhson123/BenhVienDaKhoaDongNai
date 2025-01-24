namespace Service_eHospital_DongNai_A.Implement
{
    public class NoiTru_TuThiService : BaseService<NoiTru_TuThi, INoiTru_TuThiRepository>
    , INoiTru_TuThiService
    {
    private readonly INoiTru_TuThiRepository _NoiTru_TuThiRepository;
    public NoiTru_TuThiService(INoiTru_TuThiRepository NoiTru_TuThiRepository) : base(NoiTru_TuThiRepository)
    {
    _NoiTru_TuThiRepository = NoiTru_TuThiRepository;
    }
    }
    }

