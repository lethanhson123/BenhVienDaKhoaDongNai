namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamBenh_ChuyenKhoaService : BaseService<KhamBenh_ChuyenKhoa, IKhamBenh_ChuyenKhoaRepository>
    , IKhamBenh_ChuyenKhoaService
    {
    private readonly IKhamBenh_ChuyenKhoaRepository _KhamBenh_ChuyenKhoaRepository;
    public KhamBenh_ChuyenKhoaService(IKhamBenh_ChuyenKhoaRepository KhamBenh_ChuyenKhoaRepository) : base(KhamBenh_ChuyenKhoaRepository)
    {
    _KhamBenh_ChuyenKhoaRepository = KhamBenh_ChuyenKhoaRepository;
    }
    }
    }

