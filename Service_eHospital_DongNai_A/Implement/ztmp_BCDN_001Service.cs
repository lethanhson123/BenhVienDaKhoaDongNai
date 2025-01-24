namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCDN_001Service : BaseService<ztmp_BCDN_001, Iztmp_BCDN_001Repository>
    , Iztmp_BCDN_001Service
    {
    private readonly Iztmp_BCDN_001Repository _ztmp_BCDN_001Repository;
    public ztmp_BCDN_001Service(Iztmp_BCDN_001Repository ztmp_BCDN_001Repository) : base(ztmp_BCDN_001Repository)
    {
    _ztmp_BCDN_001Repository = ztmp_BCDN_001Repository;
    }
    }
    }

