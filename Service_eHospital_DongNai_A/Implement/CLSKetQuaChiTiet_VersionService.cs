namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQuaChiTiet_VersionService : BaseService<CLSKetQuaChiTiet_Version, ICLSKetQuaChiTiet_VersionRepository>
    , ICLSKetQuaChiTiet_VersionService
    {
    private readonly ICLSKetQuaChiTiet_VersionRepository _CLSKetQuaChiTiet_VersionRepository;
    public CLSKetQuaChiTiet_VersionService(ICLSKetQuaChiTiet_VersionRepository CLSKetQuaChiTiet_VersionRepository) : base(CLSKetQuaChiTiet_VersionRepository)
    {
    _CLSKetQuaChiTiet_VersionRepository = CLSKetQuaChiTiet_VersionRepository;
    }
    }
    }

