namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCNHM_036Service : BaseService<ztmp_BCNHM_036, Iztmp_BCNHM_036Repository>
    , Iztmp_BCNHM_036Service
    {
    private readonly Iztmp_BCNHM_036Repository _ztmp_BCNHM_036Repository;
    public ztmp_BCNHM_036Service(Iztmp_BCNHM_036Repository ztmp_BCNHM_036Repository) : base(ztmp_BCNHM_036Repository)
    {
    _ztmp_BCNHM_036Repository = ztmp_BCNHM_036Repository;
    }
    }
    }

