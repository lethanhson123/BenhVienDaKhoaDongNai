namespace Service.Implement
{
    public class TaiLieuService : BaseService<TaiLieu, ITaiLieuRepository>
    , ITaiLieuService
    {
    private readonly ITaiLieuRepository _TaiLieuRepository;
    public TaiLieuService(ITaiLieuRepository TaiLieuRepository) : base(TaiLieuRepository)
    {
    _TaiLieuRepository = TaiLieuRepository;
    }
    }
    }

