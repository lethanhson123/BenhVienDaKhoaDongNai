namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonKhoService : BaseService<DuocTonKho, IDuocTonKhoRepository>
    , IDuocTonKhoService
    {
    private readonly IDuocTonKhoRepository _DuocTonKhoRepository;
    public DuocTonKhoService(IDuocTonKhoRepository DuocTonKhoRepository) : base(DuocTonKhoRepository)
    {
    _DuocTonKhoRepository = DuocTonKhoRepository;
    }
    }
    }

