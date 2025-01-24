namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnTongQuat_LienQuanBenh_SanKhoaService : BaseService<BenhAnTongQuat_LienQuanBenh_SanKhoa, IBenhAnTongQuat_LienQuanBenh_SanKhoaRepository>
    , IBenhAnTongQuat_LienQuanBenh_SanKhoaService
    {
    private readonly IBenhAnTongQuat_LienQuanBenh_SanKhoaRepository _BenhAnTongQuat_LienQuanBenh_SanKhoaRepository;
    public BenhAnTongQuat_LienQuanBenh_SanKhoaService(IBenhAnTongQuat_LienQuanBenh_SanKhoaRepository BenhAnTongQuat_LienQuanBenh_SanKhoaRepository) : base(BenhAnTongQuat_LienQuanBenh_SanKhoaRepository)
    {
    _BenhAnTongQuat_LienQuanBenh_SanKhoaRepository = BenhAnTongQuat_LienQuanBenh_SanKhoaRepository;
    }
    }
    }

