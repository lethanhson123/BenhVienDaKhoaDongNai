namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSKetQua_VTYTService : BaseService<CLSKetQua_VTYT, ICLSKetQua_VTYTRepository>
    , ICLSKetQua_VTYTService
    {
    private readonly ICLSKetQua_VTYTRepository _CLSKetQua_VTYTRepository;
    public CLSKetQua_VTYTService(ICLSKetQua_VTYTRepository CLSKetQua_VTYTRepository) : base(CLSKetQua_VTYTRepository)
    {
    _CLSKetQua_VTYTRepository = CLSKetQua_VTYTRepository;
    }
    }
    }

