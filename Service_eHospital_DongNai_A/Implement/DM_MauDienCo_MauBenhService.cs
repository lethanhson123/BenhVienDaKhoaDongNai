namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_MauDienCo_MauBenhService : BaseService<DM_MauDienCo_MauBenh, IDM_MauDienCo_MauBenhRepository>
    , IDM_MauDienCo_MauBenhService
    {
    private readonly IDM_MauDienCo_MauBenhRepository _DM_MauDienCo_MauBenhRepository;
    public DM_MauDienCo_MauBenhService(IDM_MauDienCo_MauBenhRepository DM_MauDienCo_MauBenhRepository) : base(DM_MauDienCo_MauBenhRepository)
    {
    _DM_MauDienCo_MauBenhRepository = DM_MauDienCo_MauBenhRepository;
    }
    }
    }

