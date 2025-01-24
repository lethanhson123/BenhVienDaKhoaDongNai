namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocKyTonKhoService : BaseService<DuocKyTonKho, IDuocKyTonKhoRepository>
    , IDuocKyTonKhoService
    {
    private readonly IDuocKyTonKhoRepository _DuocKyTonKhoRepository;
    public DuocKyTonKhoService(IDuocKyTonKhoRepository DuocKyTonKhoRepository) : base(DuocKyTonKhoRepository)
    {
    _DuocKyTonKhoRepository = DuocKyTonKhoRepository;
    }
    }
    }

