namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class dtpropertiesService : BaseService<dtproperties, IdtpropertiesRepository>
    , IdtpropertiesService
    {
    private readonly IdtpropertiesRepository _dtpropertiesRepository;
    public dtpropertiesService(IdtpropertiesRepository dtpropertiesRepository) : base(dtpropertiesRepository)
    {
    _dtpropertiesRepository = dtpropertiesRepository;
    }
    }
    }

