namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_PhuKhoaService : BaseService<BenhAnTongQuat_PhuKhoa, IBenhAnTongQuat_PhuKhoaRepository>
    , IBenhAnTongQuat_PhuKhoaService
    {
    private readonly IBenhAnTongQuat_PhuKhoaRepository _BenhAnTongQuat_PhuKhoaRepository;
    public BenhAnTongQuat_PhuKhoaService(IBenhAnTongQuat_PhuKhoaRepository BenhAnTongQuat_PhuKhoaRepository) : base(BenhAnTongQuat_PhuKhoaRepository)
    {
    _BenhAnTongQuat_PhuKhoaRepository = BenhAnTongQuat_PhuKhoaRepository;
    }
    }
    }

