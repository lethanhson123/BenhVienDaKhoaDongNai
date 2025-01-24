namespace Service_eHospital_DongNai_A.Implement
{
    public class CLSGhiNhanHoaChat_VTYTService : BaseService<CLSGhiNhanHoaChat_VTYT, ICLSGhiNhanHoaChat_VTYTRepository>
    , ICLSGhiNhanHoaChat_VTYTService
    {
    private readonly ICLSGhiNhanHoaChat_VTYTRepository _CLSGhiNhanHoaChat_VTYTRepository;
    public CLSGhiNhanHoaChat_VTYTService(ICLSGhiNhanHoaChat_VTYTRepository CLSGhiNhanHoaChat_VTYTRepository) : base(CLSGhiNhanHoaChat_VTYTRepository)
    {
    _CLSGhiNhanHoaChat_VTYTRepository = CLSGhiNhanHoaChat_VTYTRepository;
    }
    }
    }

