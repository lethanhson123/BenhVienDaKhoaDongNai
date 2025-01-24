namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_021101Service : BaseService<ztmp_BCTN_021101, Iztmp_BCTN_021101Repository>
    , Iztmp_BCTN_021101Service
    {
    private readonly Iztmp_BCTN_021101Repository _ztmp_BCTN_021101Repository;
    public ztmp_BCTN_021101Service(Iztmp_BCTN_021101Repository ztmp_BCTN_021101Repository) : base(ztmp_BCTN_021101Repository)
    {
    _ztmp_BCTN_021101Repository = ztmp_BCTN_021101Repository;
    }
    }
    }

