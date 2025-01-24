namespace Service_eHospital_DongNai_A.Implement
{
    public class DMDuocService : BaseService<DMDuoc, IDMDuocRepository>
    , IDMDuocService
    {
    private readonly IDMDuocRepository _DMDuocRepository;
    public DMDuocService(IDMDuocRepository DMDuocRepository) : base(DMDuocRepository)
    {
    _DMDuocRepository = DMDuocRepository;
    }
    }
    }

