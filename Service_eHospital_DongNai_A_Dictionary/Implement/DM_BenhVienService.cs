namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BenhVienService : BaseService<DM_BenhVien, IDM_BenhVienRepository>
    , IDM_BenhVienService
    {
    private readonly IDM_BenhVienRepository _DM_BenhVienRepository;
    public DM_BenhVienService(IDM_BenhVienRepository DM_BenhVienRepository) : base(DM_BenhVienRepository)
    {
    _DM_BenhVienRepository = DM_BenhVienRepository;
    }
    }
    }

