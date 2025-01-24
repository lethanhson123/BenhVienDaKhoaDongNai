namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuatService : BaseService<BenhAnTongQuat, IBenhAnTongQuatRepository>
    , IBenhAnTongQuatService
    {
    private readonly IBenhAnTongQuatRepository _BenhAnTongQuatRepository;
    public BenhAnTongQuatService(IBenhAnTongQuatRepository BenhAnTongQuatRepository) : base(BenhAnTongQuatRepository)
    {
    _BenhAnTongQuatRepository = BenhAnTongQuatRepository;
    }
    }
    }

