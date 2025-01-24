namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_021100Service : BaseService<ztmp_BCTN_021100, Iztmp_BCTN_021100Repository>
    , Iztmp_BCTN_021100Service
    {
    private readonly Iztmp_BCTN_021100Repository _ztmp_BCTN_021100Repository;
    public ztmp_BCTN_021100Service(Iztmp_BCTN_021100Repository ztmp_BCTN_021100Repository) : base(ztmp_BCTN_021100Repository)
    {
    _ztmp_BCTN_021100Repository = ztmp_BCTN_021100Repository;
    }
    }
    }

