namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BHXH_CT03Service : BaseService<ztmp_BHXH_CT03, Iztmp_BHXH_CT03Repository>
    , Iztmp_BHXH_CT03Service
    {
    private readonly Iztmp_BHXH_CT03Repository _ztmp_BHXH_CT03Repository;
    public ztmp_BHXH_CT03Service(Iztmp_BHXH_CT03Repository ztmp_BHXH_CT03Repository) : base(ztmp_BHXH_CT03Repository)
    {
    _ztmp_BHXH_CT03Repository = ztmp_BHXH_CT03Repository;
    }
    }
    }

