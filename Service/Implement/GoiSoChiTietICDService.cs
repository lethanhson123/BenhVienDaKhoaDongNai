namespace Service.Implement
{
    public class GoiSoChiTietICDService : BaseService<GoiSoChiTietICD, IGoiSoChiTietICDRepository>
    , IGoiSoChiTietICDService
    {
    private readonly IGoiSoChiTietICDRepository _GoiSoChiTietICDRepository;
    public GoiSoChiTietICDService(IGoiSoChiTietICDRepository GoiSoChiTietICDRepository) : base(GoiSoChiTietICDRepository)
    {
    _GoiSoChiTietICDRepository = GoiSoChiTietICDRepository;
    }
    }
    }

