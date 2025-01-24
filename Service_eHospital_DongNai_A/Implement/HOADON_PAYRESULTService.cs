namespace Service_eHospital_DongNai_A.Implement
{
    public class HOADON_PAYRESULTService : BaseService<HOADON_PAYRESULT, IHOADON_PAYRESULTRepository>
    , IHOADON_PAYRESULTService
    {
    private readonly IHOADON_PAYRESULTRepository _HOADON_PAYRESULTRepository;
    public HOADON_PAYRESULTService(IHOADON_PAYRESULTRepository HOADON_PAYRESULTRepository) : base(HOADON_PAYRESULTRepository)
    {
    _HOADON_PAYRESULTRepository = HOADON_PAYRESULTRepository;
    }
    }
    }

