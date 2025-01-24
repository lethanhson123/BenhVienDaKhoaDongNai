namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_Mapping_DoiTuong_2KhuService : BaseService<DM_Mapping_DoiTuong_2Khu, IDM_Mapping_DoiTuong_2KhuRepository>
    , IDM_Mapping_DoiTuong_2KhuService
    {
    private readonly IDM_Mapping_DoiTuong_2KhuRepository _DM_Mapping_DoiTuong_2KhuRepository;
    public DM_Mapping_DoiTuong_2KhuService(IDM_Mapping_DoiTuong_2KhuRepository DM_Mapping_DoiTuong_2KhuRepository) : base(DM_Mapping_DoiTuong_2KhuRepository)
    {
    _DM_Mapping_DoiTuong_2KhuRepository = DM_Mapping_DoiTuong_2KhuRepository;
    }
    }
    }

