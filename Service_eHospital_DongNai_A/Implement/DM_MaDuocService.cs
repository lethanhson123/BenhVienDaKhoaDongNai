namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_MaDuocService : BaseService<DM_MaDuoc, IDM_MaDuocRepository>
    , IDM_MaDuocService
    {
    private readonly IDM_MaDuocRepository _DM_MaDuocRepository;
    public DM_MaDuocService(IDM_MaDuocRepository DM_MaDuocRepository) : base(DM_MaDuocRepository)
    {
    _DM_MaDuocRepository = DM_MaDuocRepository;
    }
    }
    }

