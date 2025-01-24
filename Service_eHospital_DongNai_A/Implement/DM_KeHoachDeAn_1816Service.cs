namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_KeHoachDeAn_1816Service : BaseService<DM_KeHoachDeAn_1816, IDM_KeHoachDeAn_1816Repository>
    , IDM_KeHoachDeAn_1816Service
    {
    private readonly IDM_KeHoachDeAn_1816Repository _DM_KeHoachDeAn_1816Repository;
    public DM_KeHoachDeAn_1816Service(IDM_KeHoachDeAn_1816Repository DM_KeHoachDeAn_1816Repository) : base(DM_KeHoachDeAn_1816Repository)
    {
    _DM_KeHoachDeAn_1816Repository = DM_KeHoachDeAn_1816Repository;
    }
    }
    }

