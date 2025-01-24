namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_NgoaiKhoaService : BaseService<BenhAnTongQuat_NgoaiKhoa, IBenhAnTongQuat_NgoaiKhoaRepository>
    , IBenhAnTongQuat_NgoaiKhoaService
    {
    private readonly IBenhAnTongQuat_NgoaiKhoaRepository _BenhAnTongQuat_NgoaiKhoaRepository;
    public BenhAnTongQuat_NgoaiKhoaService(IBenhAnTongQuat_NgoaiKhoaRepository BenhAnTongQuat_NgoaiKhoaRepository) : base(BenhAnTongQuat_NgoaiKhoaRepository)
    {
    _BenhAnTongQuat_NgoaiKhoaRepository = BenhAnTongQuat_NgoaiKhoaRepository;
    }
    }
    }

