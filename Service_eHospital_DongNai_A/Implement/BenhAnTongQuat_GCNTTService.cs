namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GCNTTService : BaseService<BenhAnTongQuat_GCNTT, IBenhAnTongQuat_GCNTTRepository>
    , IBenhAnTongQuat_GCNTTService
    {
    private readonly IBenhAnTongQuat_GCNTTRepository _BenhAnTongQuat_GCNTTRepository;
    public BenhAnTongQuat_GCNTTService(IBenhAnTongQuat_GCNTTRepository BenhAnTongQuat_GCNTTRepository) : base(BenhAnTongQuat_GCNTTRepository)
    {
    _BenhAnTongQuat_GCNTTRepository = BenhAnTongQuat_GCNTTRepository;
    }
    }
    }

