namespace Service_eHospital_DongNai_A.Implement
{
    public class zzzThietBi_4Service : BaseService<zzzThietBi_4, IzzzThietBi_4Repository>
    , IzzzThietBi_4Service
    {
    private readonly IzzzThietBi_4Repository _zzzThietBi_4Repository;
    public zzzThietBi_4Service(IzzzThietBi_4Repository zzzThietBi_4Repository) : base(zzzThietBi_4Repository)
    {
    _zzzThietBi_4Repository = zzzThietBi_4Repository;
    }
    }
    }

