namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCDP_003Service : BaseService<ztmp_BCDP_003, Iztmp_BCDP_003Repository>
    , Iztmp_BCDP_003Service
    {
    private readonly Iztmp_BCDP_003Repository _ztmp_BCDP_003Repository;
    public ztmp_BCDP_003Service(Iztmp_BCDP_003Repository ztmp_BCDP_003Repository) : base(ztmp_BCDP_003Repository)
    {
    _ztmp_BCDP_003Repository = ztmp_BCDP_003Repository;
    }
    }
    }

