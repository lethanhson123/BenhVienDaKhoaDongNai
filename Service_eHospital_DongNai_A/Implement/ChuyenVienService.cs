namespace Service_eHospital_DongNai_A.Implement
{
    public class ChuyenVienService : BaseService<ChuyenVien, IChuyenVienRepository>
    , IChuyenVienService
    {
    private readonly IChuyenVienRepository _ChuyenVienRepository;
    public ChuyenVienService(IChuyenVienRepository ChuyenVienRepository) : base(ChuyenVienRepository)
    {
    _ChuyenVienRepository = ChuyenVienRepository;
    }
    }
    }

