namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzTrangThietBi_1Service : BaseService<zzzTrangThietBi_1, IzzzTrangThietBi_1Repository>
    , IzzzTrangThietBi_1Service
    {
    private readonly IzzzTrangThietBi_1Repository _zzzTrangThietBi_1Repository;
    public zzzTrangThietBi_1Service(IzzzTrangThietBi_1Repository zzzTrangThietBi_1Repository) : base(zzzTrangThietBi_1Repository)
    {
    _zzzTrangThietBi_1Repository = zzzTrangThietBi_1Repository;
    }
    }
    }

