namespace Service_eHospital_DongNai_A.Implement
{
    public class DM_HocVienNgoaiVienService : BaseService<DM_HocVienNgoaiVien, IDM_HocVienNgoaiVienRepository>
    , IDM_HocVienNgoaiVienService
    {
    private readonly IDM_HocVienNgoaiVienRepository _DM_HocVienNgoaiVienRepository;
    public DM_HocVienNgoaiVienService(IDM_HocVienNgoaiVienRepository DM_HocVienNgoaiVienRepository) : base(DM_HocVienNgoaiVienRepository)
    {
    _DM_HocVienNgoaiVienRepository = DM_HocVienNgoaiVienRepository;
    }
    }
    }

