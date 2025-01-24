namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BHYT_79EService : BaseService<ztmp_BHYT_79E, Iztmp_BHYT_79ERepository>
    , Iztmp_BHYT_79EService
    {
    private readonly Iztmp_BHYT_79ERepository _ztmp_BHYT_79ERepository;
    public ztmp_BHYT_79EService(Iztmp_BHYT_79ERepository ztmp_BHYT_79ERepository) : base(ztmp_BHYT_79ERepository)
    {
    _ztmp_BHYT_79ERepository = ztmp_BHYT_79ERepository;
    }
    }
    }

