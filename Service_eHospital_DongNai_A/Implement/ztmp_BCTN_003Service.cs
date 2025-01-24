namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_003Service : BaseService<ztmp_BCTN_003, Iztmp_BCTN_003Repository>
    , Iztmp_BCTN_003Service
    {
    private readonly Iztmp_BCTN_003Repository _ztmp_BCTN_003Repository;
    public ztmp_BCTN_003Service(Iztmp_BCTN_003Repository ztmp_BCTN_003Repository) : base(ztmp_BCTN_003Repository)
    {
    _ztmp_BCTN_003Repository = ztmp_BCTN_003Repository;
    }
    }
    }

