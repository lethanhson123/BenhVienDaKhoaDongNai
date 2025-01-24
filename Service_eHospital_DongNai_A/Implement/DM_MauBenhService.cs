namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_MauBenhService : BaseService<DM_MauBenh, IDM_MauBenhRepository>
    , IDM_MauBenhService
    {
    private readonly IDM_MauBenhRepository _DM_MauBenhRepository;
    public DM_MauBenhService(IDM_MauBenhRepository DM_MauBenhRepository) : base(DM_MauBenhRepository)
    {
    _DM_MauBenhRepository = DM_MauBenhRepository;
    }
    }
    }

