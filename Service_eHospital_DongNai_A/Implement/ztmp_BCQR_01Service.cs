namespace Service_eHospital_DongNai_A.Implement
{
    public class ztmp_BCQR_01Service : BaseService<ztmp_BCQR_01, Iztmp_BCQR_01Repository>
    , Iztmp_BCQR_01Service
    {
    private readonly Iztmp_BCQR_01Repository _ztmp_BCQR_01Repository;
    public ztmp_BCQR_01Service(Iztmp_BCQR_01Repository ztmp_BCQR_01Repository) : base(ztmp_BCQR_01Repository)
    {
    _ztmp_BCQR_01Repository = ztmp_BCQR_01Repository;
    }
    }
    }

