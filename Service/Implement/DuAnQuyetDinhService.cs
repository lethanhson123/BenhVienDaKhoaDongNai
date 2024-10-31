namespace Service.Implement
{
    public class DuAnQuyetDinhService : BaseService<DuAnQuyetDinh, IDuAnQuyetDinhRepository>
    , IDuAnQuyetDinhService
    {
    private readonly IDuAnQuyetDinhRepository _DuAnQuyetDinhRepository;
    public DuAnQuyetDinhService(IDuAnQuyetDinhRepository DuAnQuyetDinhRepository) : base(DuAnQuyetDinhRepository)
    {
    _DuAnQuyetDinhRepository = DuAnQuyetDinhRepository;
    }
    }
    }

