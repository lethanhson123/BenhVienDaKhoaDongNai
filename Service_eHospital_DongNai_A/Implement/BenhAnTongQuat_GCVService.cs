namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GCVService : BaseService<BenhAnTongQuat_GCV, IBenhAnTongQuat_GCVRepository>
    , IBenhAnTongQuat_GCVService
    {
    private readonly IBenhAnTongQuat_GCVRepository _BenhAnTongQuat_GCVRepository;
    public BenhAnTongQuat_GCVService(IBenhAnTongQuat_GCVRepository BenhAnTongQuat_GCVRepository) : base(BenhAnTongQuat_GCVRepository)
    {
    _BenhAnTongQuat_GCVRepository = BenhAnTongQuat_GCVRepository;
    }
    }
    }

