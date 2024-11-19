namespace Service.Implement
{
    public class GoiSoChiTietService : BaseService<GoiSoChiTiet, IGoiSoChiTietRepository>
    , IGoiSoChiTietService
    {
    private readonly IGoiSoChiTietRepository _GoiSoChiTietRepository;
    public GoiSoChiTietService(IGoiSoChiTietRepository GoiSoChiTietRepository) : base(GoiSoChiTietRepository)
    {
    _GoiSoChiTietRepository = GoiSoChiTietRepository;
    }
    }
    }

