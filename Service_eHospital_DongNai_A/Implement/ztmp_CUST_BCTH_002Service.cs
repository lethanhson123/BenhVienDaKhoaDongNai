namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_CUST_BCTH_002Service : BaseService<ztmp_CUST_BCTH_002, Iztmp_CUST_BCTH_002Repository>
    , Iztmp_CUST_BCTH_002Service
    {
    private readonly Iztmp_CUST_BCTH_002Repository _ztmp_CUST_BCTH_002Repository;
    public ztmp_CUST_BCTH_002Service(Iztmp_CUST_BCTH_002Repository ztmp_CUST_BCTH_002Repository) : base(ztmp_CUST_BCTH_002Repository)
    {
    _ztmp_CUST_BCTH_002Repository = ztmp_CUST_BCTH_002Repository;
    }
    }
    }

