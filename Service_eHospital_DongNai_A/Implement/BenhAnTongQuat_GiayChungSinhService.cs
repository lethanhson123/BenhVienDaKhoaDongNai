namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_GiayChungSinhService : BaseService<BenhAnTongQuat_GiayChungSinh, IBenhAnTongQuat_GiayChungSinhRepository>
    , IBenhAnTongQuat_GiayChungSinhService
    {
    private readonly IBenhAnTongQuat_GiayChungSinhRepository _BenhAnTongQuat_GiayChungSinhRepository;
    public BenhAnTongQuat_GiayChungSinhService(IBenhAnTongQuat_GiayChungSinhRepository BenhAnTongQuat_GiayChungSinhRepository) : base(BenhAnTongQuat_GiayChungSinhRepository)
    {
    _BenhAnTongQuat_GiayChungSinhRepository = BenhAnTongQuat_GiayChungSinhRepository;
    }
    }
    }

