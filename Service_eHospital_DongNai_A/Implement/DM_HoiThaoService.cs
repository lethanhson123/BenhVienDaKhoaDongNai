namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_HoiThaoService : BaseService<DM_HoiThao, IDM_HoiThaoRepository>
    , IDM_HoiThaoService
    {
    private readonly IDM_HoiThaoRepository _DM_HoiThaoRepository;
    public DM_HoiThaoService(IDM_HoiThaoRepository DM_HoiThaoRepository) : base(DM_HoiThaoRepository)
    {
    _DM_HoiThaoRepository = DM_HoiThaoRepository;
    }
    }
    }

