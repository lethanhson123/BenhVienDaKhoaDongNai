namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BHYT_80Service : BaseService<ztmp_BHYT_80, Iztmp_BHYT_80Repository>
    , Iztmp_BHYT_80Service
    {
    private readonly Iztmp_BHYT_80Repository _ztmp_BHYT_80Repository;
    public ztmp_BHYT_80Service(Iztmp_BHYT_80Repository ztmp_BHYT_80Repository) : base(ztmp_BHYT_80Repository)
    {
    _ztmp_BHYT_80Repository = ztmp_BHYT_80Repository;
    }
    }
    }

