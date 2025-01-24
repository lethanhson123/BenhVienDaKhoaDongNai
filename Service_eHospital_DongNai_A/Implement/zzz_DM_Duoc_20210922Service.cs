namespace Service_eHospital_DongNai_A.Implement
{
    public class zzz_DM_Duoc_20210922Service : BaseService<zzz_DM_Duoc_20210922, Izzz_DM_Duoc_20210922Repository>
    , Izzz_DM_Duoc_20210922Service
    {
    private readonly Izzz_DM_Duoc_20210922Repository _zzz_DM_Duoc_20210922Repository;
    public zzz_DM_Duoc_20210922Service(Izzz_DM_Duoc_20210922Repository zzz_DM_Duoc_20210922Repository) : base(zzz_DM_Duoc_20210922Repository)
    {
    _zzz_DM_Duoc_20210922Repository = zzz_DM_Duoc_20210922Repository;
    }
    }
    }

