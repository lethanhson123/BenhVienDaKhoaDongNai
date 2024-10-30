namespace Service.Implement
{
    public class DuAnThuChiService : BaseService<DuAnThuChi, IDuAnThuChiRepository>
    , IDuAnThuChiService
    {
    private readonly IDuAnThuChiRepository _DuAnThuChiRepository;
    public DuAnThuChiService(IDuAnThuChiRepository DuAnThuChiRepository) : base(DuAnThuChiRepository)
    {
    _DuAnThuChiRepository = DuAnThuChiRepository;
    }
    }
    }

