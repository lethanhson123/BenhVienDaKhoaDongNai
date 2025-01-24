namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCDM_006Service : BaseService<ztmp_BCDM_006, Iztmp_BCDM_006Repository>
    , Iztmp_BCDM_006Service
    {
    private readonly Iztmp_BCDM_006Repository _ztmp_BCDM_006Repository;
    public ztmp_BCDM_006Service(Iztmp_BCDM_006Repository ztmp_BCDM_006Repository) : base(ztmp_BCDM_006Repository)
    {
    _ztmp_BCDM_006Repository = ztmp_BCDM_006Repository;
    }
    }
    }

