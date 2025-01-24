namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_NhiKhoaService : BaseService<BenhAnTongQuat_NhiKhoa, IBenhAnTongQuat_NhiKhoaRepository>
    , IBenhAnTongQuat_NhiKhoaService
    {
    private readonly IBenhAnTongQuat_NhiKhoaRepository _BenhAnTongQuat_NhiKhoaRepository;
    public BenhAnTongQuat_NhiKhoaService(IBenhAnTongQuat_NhiKhoaRepository BenhAnTongQuat_NhiKhoaRepository) : base(BenhAnTongQuat_NhiKhoaRepository)
    {
    _BenhAnTongQuat_NhiKhoaRepository = BenhAnTongQuat_NhiKhoaRepository;
    }
    }
    }

