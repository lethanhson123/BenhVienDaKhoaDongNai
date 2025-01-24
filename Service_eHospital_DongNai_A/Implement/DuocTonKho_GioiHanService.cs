namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_GioiHanService : BaseService<DuocTonKho_GioiHan, IDuocTonKho_GioiHanRepository>
    , IDuocTonKho_GioiHanService
    {
    private readonly IDuocTonKho_GioiHanRepository _DuocTonKho_GioiHanRepository;
    public DuocTonKho_GioiHanService(IDuocTonKho_GioiHanRepository DuocTonKho_GioiHanRepository) : base(DuocTonKho_GioiHanRepository)
    {
    _DuocTonKho_GioiHanRepository = DuocTonKho_GioiHanRepository;
    }
    }
    }

