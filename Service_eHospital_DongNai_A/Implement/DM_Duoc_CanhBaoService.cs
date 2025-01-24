namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_Duoc_CanhBaoService : BaseService<DM_Duoc_CanhBao, IDM_Duoc_CanhBaoRepository>
    , IDM_Duoc_CanhBaoService
    {
    private readonly IDM_Duoc_CanhBaoRepository _DM_Duoc_CanhBaoRepository;
    public DM_Duoc_CanhBaoService(IDM_Duoc_CanhBaoRepository DM_Duoc_CanhBaoRepository) : base(DM_Duoc_CanhBaoRepository)
    {
    _DM_Duoc_CanhBaoRepository = DM_Duoc_CanhBaoRepository;
    }
    }
    }

