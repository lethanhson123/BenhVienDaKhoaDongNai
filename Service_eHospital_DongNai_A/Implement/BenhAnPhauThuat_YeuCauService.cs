namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuat_YeuCauService : BaseService<BenhAnPhauThuat_YeuCau, IBenhAnPhauThuat_YeuCauRepository>
    , IBenhAnPhauThuat_YeuCauService
    {
    private readonly IBenhAnPhauThuat_YeuCauRepository _BenhAnPhauThuat_YeuCauRepository;
    public BenhAnPhauThuat_YeuCauService(IBenhAnPhauThuat_YeuCauRepository BenhAnPhauThuat_YeuCauRepository) : base(BenhAnPhauThuat_YeuCauRepository)
    {
    _BenhAnPhauThuat_YeuCauRepository = BenhAnPhauThuat_YeuCauRepository;
    }
    }
    }

