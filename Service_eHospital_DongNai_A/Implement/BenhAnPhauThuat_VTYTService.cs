namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_VTYTService : BaseService<BenhAnPhauThuat_VTYT, IBenhAnPhauThuat_VTYTRepository>
    , IBenhAnPhauThuat_VTYTService
    {
    private readonly IBenhAnPhauThuat_VTYTRepository _BenhAnPhauThuat_VTYTRepository;
    public BenhAnPhauThuat_VTYTService(IBenhAnPhauThuat_VTYTRepository BenhAnPhauThuat_VTYTRepository) : base(BenhAnPhauThuat_VTYTRepository)
    {
    _BenhAnPhauThuat_VTYTRepository = BenhAnPhauThuat_VTYTRepository;
    }
    }
    }

