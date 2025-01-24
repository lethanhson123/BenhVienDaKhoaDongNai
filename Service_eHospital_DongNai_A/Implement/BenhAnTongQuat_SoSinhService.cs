namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_SoSinhService : BaseService<BenhAnTongQuat_SoSinh, IBenhAnTongQuat_SoSinhRepository>
    , IBenhAnTongQuat_SoSinhService
    {
    private readonly IBenhAnTongQuat_SoSinhRepository _BenhAnTongQuat_SoSinhRepository;
    public BenhAnTongQuat_SoSinhService(IBenhAnTongQuat_SoSinhRepository BenhAnTongQuat_SoSinhRepository) : base(BenhAnTongQuat_SoSinhRepository)
    {
    _BenhAnTongQuat_SoSinhRepository = BenhAnTongQuat_SoSinhRepository;
    }
    }
    }

