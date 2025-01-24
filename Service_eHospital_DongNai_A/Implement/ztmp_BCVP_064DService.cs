namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCVP_064DService : BaseService<ztmp_BCVP_064D, Iztmp_BCVP_064DRepository>
    , Iztmp_BCVP_064DService
    {
    private readonly Iztmp_BCVP_064DRepository _ztmp_BCVP_064DRepository;
    public ztmp_BCVP_064DService(Iztmp_BCVP_064DRepository ztmp_BCVP_064DRepository) : base(ztmp_BCVP_064DRepository)
    {
    _ztmp_BCVP_064DRepository = ztmp_BCVP_064DRepository;
    }
    }
    }

