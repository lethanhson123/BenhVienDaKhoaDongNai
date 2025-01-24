namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_DichVu_20160330Service : BaseService<DM_DichVu_20160330, IDM_DichVu_20160330Repository>
    , IDM_DichVu_20160330Service
    {
    private readonly IDM_DichVu_20160330Repository _DM_DichVu_20160330Repository;
    public DM_DichVu_20160330Service(IDM_DichVu_20160330Repository DM_DichVu_20160330Repository) : base(DM_DichVu_20160330Repository)
    {
    _DM_DichVu_20160330Repository = DM_DichVu_20160330Repository;
    }
    }
    }

