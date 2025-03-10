namespace Service.Implement
{
    public class ThongKeChiTietService : BaseService<ThongKeChiTiet, IThongKeChiTietRepository>
    , IThongKeChiTietService
    {
    private readonly IThongKeChiTietRepository _ThongKeChiTietRepository;
    public ThongKeChiTietService(IThongKeChiTietRepository ThongKeChiTietRepository) : base(ThongKeChiTietRepository)
    {
    _ThongKeChiTietRepository = ThongKeChiTietRepository;
    }
    }
    }

