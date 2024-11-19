namespace Service.Implement
{
    public class GoiSoService : BaseService<GoiSo, IGoiSoRepository>
    , IGoiSoService
    {
    private readonly IGoiSoRepository _GoiSoRepository;
    public GoiSoService(IGoiSoRepository GoiSoRepository) : base(GoiSoRepository)
    {
    _GoiSoRepository = GoiSoRepository;
    }
    }
    }

