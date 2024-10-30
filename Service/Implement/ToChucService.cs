namespace Service.Implement
{
    public class ToChucService : BaseService<ToChuc, IToChucRepository>
    , IToChucService
    {
    private readonly IToChucRepository _ToChucRepository;
    public ToChucService(IToChucRepository ToChucRepository) : base(ToChucRepository)
    {
    _ToChucRepository = ToChucRepository;
    }
    }
    }

