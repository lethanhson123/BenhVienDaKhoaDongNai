namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_009Service : BaseService<ztmp_BCTN_009, Iztmp_BCTN_009Repository>
    , Iztmp_BCTN_009Service
    {
    private readonly Iztmp_BCTN_009Repository _ztmp_BCTN_009Repository;
    public ztmp_BCTN_009Service(Iztmp_BCTN_009Repository ztmp_BCTN_009Repository) : base(ztmp_BCTN_009Repository)
    {
    _ztmp_BCTN_009Repository = ztmp_BCTN_009Repository;
    }
    }
    }

