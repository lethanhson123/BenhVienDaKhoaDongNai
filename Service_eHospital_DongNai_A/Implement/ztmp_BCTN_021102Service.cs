namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_021102Service : BaseService<ztmp_BCTN_021102, Iztmp_BCTN_021102Repository>
    , Iztmp_BCTN_021102Service
    {
    private readonly Iztmp_BCTN_021102Repository _ztmp_BCTN_021102Repository;
    public ztmp_BCTN_021102Service(Iztmp_BCTN_021102Repository ztmp_BCTN_021102Repository) : base(ztmp_BCTN_021102Repository)
    {
    _ztmp_BCTN_021102Repository = ztmp_BCTN_021102Repository;
    }
    }
    }

