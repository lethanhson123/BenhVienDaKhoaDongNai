namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_NaoPhaThaiService : BaseService<BenhAnTongQuat_NaoPhaThai, IBenhAnTongQuat_NaoPhaThaiRepository>
    , IBenhAnTongQuat_NaoPhaThaiService
    {
    private readonly IBenhAnTongQuat_NaoPhaThaiRepository _BenhAnTongQuat_NaoPhaThaiRepository;
    public BenhAnTongQuat_NaoPhaThaiService(IBenhAnTongQuat_NaoPhaThaiRepository BenhAnTongQuat_NaoPhaThaiRepository) : base(BenhAnTongQuat_NaoPhaThaiRepository)
    {
    _BenhAnTongQuat_NaoPhaThaiRepository = BenhAnTongQuat_NaoPhaThaiRepository;
    }
    }
    }

