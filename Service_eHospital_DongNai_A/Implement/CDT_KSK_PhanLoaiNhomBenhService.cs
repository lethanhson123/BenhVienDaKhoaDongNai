namespace Service_eHospital_DongNai_A.Implement
{
    public class CDT_KSK_PhanLoaiNhomBenhService : BaseService<CDT_KSK_PhanLoaiNhomBenh, ICDT_KSK_PhanLoaiNhomBenhRepository>
    , ICDT_KSK_PhanLoaiNhomBenhService
    {
    private readonly ICDT_KSK_PhanLoaiNhomBenhRepository _CDT_KSK_PhanLoaiNhomBenhRepository;
    public CDT_KSK_PhanLoaiNhomBenhService(ICDT_KSK_PhanLoaiNhomBenhRepository CDT_KSK_PhanLoaiNhomBenhRepository) : base(CDT_KSK_PhanLoaiNhomBenhRepository)
    {
    _CDT_KSK_PhanLoaiNhomBenhRepository = CDT_KSK_PhanLoaiNhomBenhRepository;
    }
    }
    }

