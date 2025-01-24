namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_TamDucService : BaseService<BenhAnPhauThuat_TamDuc, IBenhAnPhauThuat_TamDucRepository>
    , IBenhAnPhauThuat_TamDucService
    {
    private readonly IBenhAnPhauThuat_TamDucRepository _BenhAnPhauThuat_TamDucRepository;
    public BenhAnPhauThuat_TamDucService(IBenhAnPhauThuat_TamDucRepository BenhAnPhauThuat_TamDucRepository) : base(BenhAnPhauThuat_TamDucRepository)
    {
    _BenhAnPhauThuat_TamDucRepository = BenhAnPhauThuat_TamDucRepository;
    }
    }
    }

