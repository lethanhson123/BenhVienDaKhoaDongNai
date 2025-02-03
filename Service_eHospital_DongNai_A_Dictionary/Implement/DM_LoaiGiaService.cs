namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_LoaiGiaService : BaseService<DM_LoaiGia, IDM_LoaiGiaRepository>
    , IDM_LoaiGiaService
    {
    private readonly IDM_LoaiGiaRepository _DM_LoaiGiaRepository;
    public DM_LoaiGiaService(IDM_LoaiGiaRepository DM_LoaiGiaRepository) : base(DM_LoaiGiaRepository)
    {
    _DM_LoaiGiaRepository = DM_LoaiGiaRepository;
    }
    }
    }

