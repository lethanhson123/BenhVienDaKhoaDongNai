namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GCSService : BaseService<BenhAnTongQuat_GCS, IBenhAnTongQuat_GCSRepository>
    , IBenhAnTongQuat_GCSService
    {
    private readonly IBenhAnTongQuat_GCSRepository _BenhAnTongQuat_GCSRepository;
    public BenhAnTongQuat_GCSService(IBenhAnTongQuat_GCSRepository BenhAnTongQuat_GCSRepository) : base(BenhAnTongQuat_GCSRepository)
    {
    _BenhAnTongQuat_GCSRepository = BenhAnTongQuat_GCSRepository;
    }
    }
    }

