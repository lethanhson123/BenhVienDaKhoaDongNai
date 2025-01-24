namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_DichVu_201603Service : BaseService<DM_DichVu_201603, IDM_DichVu_201603Repository>
    , IDM_DichVu_201603Service
    {
    private readonly IDM_DichVu_201603Repository _DM_DichVu_201603Repository;
    public DM_DichVu_201603Service(IDM_DichVu_201603Repository DM_DichVu_201603Repository) : base(DM_DichVu_201603Repository)
    {
    _DM_DichVu_201603Repository = DM_DichVu_201603Repository;
    }
    }
    }

