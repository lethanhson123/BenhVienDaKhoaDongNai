namespace Service_eHospital_DongNai_A.Implement
{
    public class KiemDiemTuVong_ThanhVienService : BaseService<KiemDiemTuVong_ThanhVien, IKiemDiemTuVong_ThanhVienRepository>
    , IKiemDiemTuVong_ThanhVienService
    {
    private readonly IKiemDiemTuVong_ThanhVienRepository _KiemDiemTuVong_ThanhVienRepository;
    public KiemDiemTuVong_ThanhVienService(IKiemDiemTuVong_ThanhVienRepository KiemDiemTuVong_ThanhVienRepository) : base(KiemDiemTuVong_ThanhVienRepository)
    {
    _KiemDiemTuVong_ThanhVienRepository = KiemDiemTuVong_ThanhVienRepository;
    }
    }
    }

