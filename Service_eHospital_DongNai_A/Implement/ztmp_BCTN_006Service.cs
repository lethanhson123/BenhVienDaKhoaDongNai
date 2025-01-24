namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_006Service : BaseService<ztmp_BCTN_006, Iztmp_BCTN_006Repository>
    , Iztmp_BCTN_006Service
    {
    private readonly Iztmp_BCTN_006Repository _ztmp_BCTN_006Repository;
    public ztmp_BCTN_006Service(Iztmp_BCTN_006Repository ztmp_BCTN_006Repository) : base(ztmp_BCTN_006Repository)
    {
    _ztmp_BCTN_006Repository = ztmp_BCTN_006Repository;
    }
    }
    }

