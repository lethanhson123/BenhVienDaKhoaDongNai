namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_NoiKhoaService : BaseService<BenhAnTongQuat_NoiKhoa, IBenhAnTongQuat_NoiKhoaRepository>
    , IBenhAnTongQuat_NoiKhoaService
    {
    private readonly IBenhAnTongQuat_NoiKhoaRepository _BenhAnTongQuat_NoiKhoaRepository;
    public BenhAnTongQuat_NoiKhoaService(IBenhAnTongQuat_NoiKhoaRepository BenhAnTongQuat_NoiKhoaRepository) : base(BenhAnTongQuat_NoiKhoaRepository)
    {
    _BenhAnTongQuat_NoiKhoaRepository = BenhAnTongQuat_NoiKhoaRepository;
    }
    }
    }

