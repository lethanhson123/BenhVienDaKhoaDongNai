namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_EKipService : BaseService<BenhAnPhauThuat_EKip, IBenhAnPhauThuat_EKipRepository>
    , IBenhAnPhauThuat_EKipService
    {
    private readonly IBenhAnPhauThuat_EKipRepository _BenhAnPhauThuat_EKipRepository;
    public BenhAnPhauThuat_EKipService(IBenhAnPhauThuat_EKipRepository BenhAnPhauThuat_EKipRepository) : base(BenhAnPhauThuat_EKipRepository)
    {
    _BenhAnPhauThuat_EKipRepository = BenhAnPhauThuat_EKipRepository;
    }
    }
    }

