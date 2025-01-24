namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_NgayNghiLeService : BaseService<DM_NgayNghiLe, IDM_NgayNghiLeRepository>
    , IDM_NgayNghiLeService
    {
    private readonly IDM_NgayNghiLeRepository _DM_NgayNghiLeRepository;
    public DM_NgayNghiLeService(IDM_NgayNghiLeRepository DM_NgayNghiLeRepository) : base(DM_NgayNghiLeRepository)
    {
    _DM_NgayNghiLeRepository = DM_NgayNghiLeRepository;
    }
    }
    }

