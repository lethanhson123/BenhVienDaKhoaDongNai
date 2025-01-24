namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_MauDienCoService : BaseService<DM_MauDienCo, IDM_MauDienCoRepository>
    , IDM_MauDienCoService
    {
    private readonly IDM_MauDienCoRepository _DM_MauDienCoRepository;
    public DM_MauDienCoService(IDM_MauDienCoRepository DM_MauDienCoRepository) : base(DM_MauDienCoRepository)
    {
    _DM_MauDienCoRepository = DM_MauDienCoRepository;
    }
    }
    }

