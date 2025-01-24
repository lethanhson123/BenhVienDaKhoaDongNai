namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_009AService : BaseService<ztmp_BCTN_009A, Iztmp_BCTN_009ARepository>
    , Iztmp_BCTN_009AService
    {
    private readonly Iztmp_BCTN_009ARepository _ztmp_BCTN_009ARepository;
    public ztmp_BCTN_009AService(Iztmp_BCTN_009ARepository ztmp_BCTN_009ARepository) : base(ztmp_BCTN_009ARepository)
    {
    _ztmp_BCTN_009ARepository = ztmp_BCTN_009ARepository;
    }
    }
    }

