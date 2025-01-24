namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_TMHService : BaseService<BenhAnTongQuat_TMH, IBenhAnTongQuat_TMHRepository>
    , IBenhAnTongQuat_TMHService
    {
    private readonly IBenhAnTongQuat_TMHRepository _BenhAnTongQuat_TMHRepository;
    public BenhAnTongQuat_TMHService(IBenhAnTongQuat_TMHRepository BenhAnTongQuat_TMHRepository) : base(BenhAnTongQuat_TMHRepository)
    {
    _BenhAnTongQuat_TMHRepository = BenhAnTongQuat_TMHRepository;
    }
    }
    }

