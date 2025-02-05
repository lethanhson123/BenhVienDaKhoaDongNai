namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_LoaiBenhAnService : BaseService<DM_LoaiBenhAn, IDM_LoaiBenhAnRepository>
    , IDM_LoaiBenhAnService
    {
    private readonly IDM_LoaiBenhAnRepository _DM_LoaiBenhAnRepository;
    public DM_LoaiBenhAnService(IDM_LoaiBenhAnRepository DM_LoaiBenhAnRepository) : base(DM_LoaiBenhAnRepository)
    {
    _DM_LoaiBenhAnRepository = DM_LoaiBenhAnRepository;
    }
    }
    }

