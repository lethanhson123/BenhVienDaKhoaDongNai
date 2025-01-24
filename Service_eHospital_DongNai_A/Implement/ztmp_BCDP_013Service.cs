namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCDP_013Service : BaseService<ztmp_BCDP_013, Iztmp_BCDP_013Repository>
    , Iztmp_BCDP_013Service
    {
    private readonly Iztmp_BCDP_013Repository _ztmp_BCDP_013Repository;
    public ztmp_BCDP_013Service(Iztmp_BCDP_013Repository ztmp_BCDP_013Repository) : base(ztmp_BCDP_013Repository)
    {
    _ztmp_BCDP_013Repository = ztmp_BCDP_013Repository;
    }
    }
    }

