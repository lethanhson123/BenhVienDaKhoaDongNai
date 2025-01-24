namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BHYT_RV_2019Service : BaseService<ztmp_BHYT_RV_2019, Iztmp_BHYT_RV_2019Repository>
    , Iztmp_BHYT_RV_2019Service
    {
    private readonly Iztmp_BHYT_RV_2019Repository _ztmp_BHYT_RV_2019Repository;
    public ztmp_BHYT_RV_2019Service(Iztmp_BHYT_RV_2019Repository ztmp_BHYT_RV_2019Repository) : base(ztmp_BHYT_RV_2019Repository)
    {
    _ztmp_BHYT_RV_2019Repository = ztmp_BHYT_RV_2019Repository;
    }
    }
    }

