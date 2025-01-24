namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_VersionService : BaseService<CLSKetQua_Version, ICLSKetQua_VersionRepository>
    , ICLSKetQua_VersionService
    {
    private readonly ICLSKetQua_VersionRepository _CLSKetQua_VersionRepository;
    public CLSKetQua_VersionService(ICLSKetQua_VersionRepository CLSKetQua_VersionRepository) : base(CLSKetQua_VersionRepository)
    {
    _CLSKetQua_VersionRepository = CLSKetQua_VersionRepository;
    }
    }
    }

