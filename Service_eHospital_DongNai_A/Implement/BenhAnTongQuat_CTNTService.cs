namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_CTNTService : BaseService<BenhAnTongQuat_CTNT, IBenhAnTongQuat_CTNTRepository>
    , IBenhAnTongQuat_CTNTService
    {
    private readonly IBenhAnTongQuat_CTNTRepository _BenhAnTongQuat_CTNTRepository;
    public BenhAnTongQuat_CTNTService(IBenhAnTongQuat_CTNTRepository BenhAnTongQuat_CTNTRepository) : base(BenhAnTongQuat_CTNTRepository)
    {
    _BenhAnTongQuat_CTNTRepository = BenhAnTongQuat_CTNTRepository;
    }
    }
    }

