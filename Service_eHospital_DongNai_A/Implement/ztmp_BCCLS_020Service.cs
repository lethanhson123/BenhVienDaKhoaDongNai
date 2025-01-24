namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCCLS_020Service : BaseService<ztmp_BCCLS_020, Iztmp_BCCLS_020Repository>
    , Iztmp_BCCLS_020Service
    {
    private readonly Iztmp_BCCLS_020Repository _ztmp_BCCLS_020Repository;
    public ztmp_BCCLS_020Service(Iztmp_BCCLS_020Repository ztmp_BCCLS_020Repository) : base(ztmp_BCCLS_020Repository)
    {
    _ztmp_BCCLS_020Repository = ztmp_BCCLS_020Repository;
    }
    }
    }

