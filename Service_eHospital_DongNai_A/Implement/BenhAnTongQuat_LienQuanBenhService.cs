namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_LienQuanBenhService : BaseService<BenhAnTongQuat_LienQuanBenh, IBenhAnTongQuat_LienQuanBenhRepository>
    , IBenhAnTongQuat_LienQuanBenhService
    {
    private readonly IBenhAnTongQuat_LienQuanBenhRepository _BenhAnTongQuat_LienQuanBenhRepository;
    public BenhAnTongQuat_LienQuanBenhService(IBenhAnTongQuat_LienQuanBenhRepository BenhAnTongQuat_LienQuanBenhRepository) : base(BenhAnTongQuat_LienQuanBenhRepository)
    {
    _BenhAnTongQuat_LienQuanBenhRepository = BenhAnTongQuat_LienQuanBenhRepository;
    }
    }
    }

