namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_RHMService : BaseService<BenhAnTongQuat_RHM, IBenhAnTongQuat_RHMRepository>
    , IBenhAnTongQuat_RHMService
    {
    private readonly IBenhAnTongQuat_RHMRepository _BenhAnTongQuat_RHMRepository;
    public BenhAnTongQuat_RHMService(IBenhAnTongQuat_RHMRepository BenhAnTongQuat_RHMRepository) : base(BenhAnTongQuat_RHMRepository)
    {
    _BenhAnTongQuat_RHMRepository = BenhAnTongQuat_RHMRepository;
    }
    }
    }

