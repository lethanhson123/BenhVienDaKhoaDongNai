namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_SanKhoaService : BaseService<BenhAnTongQuat_SanKhoa, IBenhAnTongQuat_SanKhoaRepository>
    , IBenhAnTongQuat_SanKhoaService
    {
    private readonly IBenhAnTongQuat_SanKhoaRepository _BenhAnTongQuat_SanKhoaRepository;
    public BenhAnTongQuat_SanKhoaService(IBenhAnTongQuat_SanKhoaRepository BenhAnTongQuat_SanKhoaRepository) : base(BenhAnTongQuat_SanKhoaRepository)
    {
    _BenhAnTongQuat_SanKhoaRepository = BenhAnTongQuat_SanKhoaRepository;
    }
    }
    }

