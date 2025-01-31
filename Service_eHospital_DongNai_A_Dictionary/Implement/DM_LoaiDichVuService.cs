namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_LoaiDichVuService : BaseService<DM_LoaiDichVu, IDM_LoaiDichVuRepository>
    , IDM_LoaiDichVuService
    {
    private readonly IDM_LoaiDichVuRepository _DM_LoaiDichVuRepository;
    public DM_LoaiDichVuService(IDM_LoaiDichVuRepository DM_LoaiDichVuRepository) : base(DM_LoaiDichVuRepository)
    {
    _DM_LoaiDichVuRepository = DM_LoaiDichVuRepository;
    }
    }
    }

