namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_DuocHuService : BaseService<DuocTonKho_DuocHu, IDuocTonKho_DuocHuRepository>
    , IDuocTonKho_DuocHuService
    {
    private readonly IDuocTonKho_DuocHuRepository _DuocTonKho_DuocHuRepository;
    public DuocTonKho_DuocHuService(IDuocTonKho_DuocHuRepository DuocTonKho_DuocHuRepository) : base(DuocTonKho_DuocHuRepository)
    {
    _DuocTonKho_DuocHuRepository = DuocTonKho_DuocHuRepository;
    }
    }
    }

