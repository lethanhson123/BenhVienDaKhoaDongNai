namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GBTService : BaseService<BenhAnTongQuat_GBT, IBenhAnTongQuat_GBTRepository>
    , IBenhAnTongQuat_GBTService
    {
    private readonly IBenhAnTongQuat_GBTRepository _BenhAnTongQuat_GBTRepository;
    public BenhAnTongQuat_GBTService(IBenhAnTongQuat_GBTRepository BenhAnTongQuat_GBTRepository) : base(BenhAnTongQuat_GBTRepository)
    {
    _BenhAnTongQuat_GBTRepository = BenhAnTongQuat_GBTRepository;
    }
    }
    }

