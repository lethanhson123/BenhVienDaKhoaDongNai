namespace Service.Implement
{
    public class ThongKeService : BaseService<ThongKe, IThongKeRepository>
    , IThongKeService
    {
    private readonly IThongKeRepository _ThongKeRepository;
    public ThongKeService(IThongKeRepository ThongKeRepository) : base(ThongKeRepository)
    {
    _ThongKeRepository = ThongKeRepository;
    }
    }
    }

