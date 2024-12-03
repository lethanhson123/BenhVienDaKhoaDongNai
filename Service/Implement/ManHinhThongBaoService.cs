namespace Service.Implement
{
    public class ManHinhThongBaoService : BaseService<ManHinhThongBao, IManHinhThongBaoRepository>
    , IManHinhThongBaoService
    {
    private readonly IManHinhThongBaoRepository _ManHinhThongBaoRepository;
    public ManHinhThongBaoService(IManHinhThongBaoRepository ManHinhThongBaoRepository) : base(ManHinhThongBaoRepository)
    {
    _ManHinhThongBaoRepository = ManHinhThongBaoRepository;
    }
    }
    }

