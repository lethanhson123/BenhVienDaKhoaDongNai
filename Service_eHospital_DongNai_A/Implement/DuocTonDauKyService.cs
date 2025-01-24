namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonDauKyService : BaseService<DuocTonDauKy, IDuocTonDauKyRepository>
    , IDuocTonDauKyService
    {
    private readonly IDuocTonDauKyRepository _DuocTonDauKyRepository;
    public DuocTonDauKyService(IDuocTonDauKyRepository DuocTonDauKyRepository) : base(DuocTonDauKyRepository)
    {
    _DuocTonDauKyRepository = DuocTonDauKyRepository;
    }
    }
    }

