namespace Service.Implement
{
    public class DuAnTapTinDinhKemService : BaseService<DuAnTapTinDinhKem, IDuAnTapTinDinhKemRepository>
    , IDuAnTapTinDinhKemService
    {
    private readonly IDuAnTapTinDinhKemRepository _DuAnTapTinDinhKemRepository;
    public DuAnTapTinDinhKemService(IDuAnTapTinDinhKemRepository DuAnTapTinDinhKemRepository) : base(DuAnTapTinDinhKemRepository)
    {
    _DuAnTapTinDinhKemRepository = DuAnTapTinDinhKemRepository;
    }
    }
    }

