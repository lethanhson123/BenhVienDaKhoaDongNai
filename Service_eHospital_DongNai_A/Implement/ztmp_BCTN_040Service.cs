namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_040Service : BaseService<ztmp_BCTN_040, Iztmp_BCTN_040Repository>
    , Iztmp_BCTN_040Service
    {
    private readonly Iztmp_BCTN_040Repository _ztmp_BCTN_040Repository;
    public ztmp_BCTN_040Service(Iztmp_BCTN_040Repository ztmp_BCTN_040Repository) : base(ztmp_BCTN_040Repository)
    {
    _ztmp_BCTN_040Repository = ztmp_BCTN_040Repository;
    }
    }
    }

