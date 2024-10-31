namespace Service.Implement
{
    public class DuAnQuyetToanService : BaseService<DuAnQuyetToan, IDuAnQuyetToanRepository>
    , IDuAnQuyetToanService
    {
    private readonly IDuAnQuyetToanRepository _DuAnQuyetToanRepository;
    public DuAnQuyetToanService(IDuAnQuyetToanRepository DuAnQuyetToanRepository) : base(DuAnQuyetToanRepository)
    {
    _DuAnQuyetToanRepository = DuAnQuyetToanRepository;
    }
    }
    }

