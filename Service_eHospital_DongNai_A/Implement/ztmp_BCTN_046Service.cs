namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCTN_046Service : BaseService<ztmp_BCTN_046, Iztmp_BCTN_046Repository>
    , Iztmp_BCTN_046Service
    {
    private readonly Iztmp_BCTN_046Repository _ztmp_BCTN_046Repository;
    public ztmp_BCTN_046Service(Iztmp_BCTN_046Repository ztmp_BCTN_046Repository) : base(ztmp_BCTN_046Repository)
    {
    _ztmp_BCTN_046Repository = ztmp_BCTN_046Repository;
    }
    }
    }

