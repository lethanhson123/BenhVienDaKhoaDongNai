namespace Service.Implement
{
    public class ManHinhTapTinDinhKemService : BaseService<ManHinhTapTinDinhKem, IManHinhTapTinDinhKemRepository>
    , IManHinhTapTinDinhKemService
    {
    private readonly IManHinhTapTinDinhKemRepository _ManHinhTapTinDinhKemRepository;
    public ManHinhTapTinDinhKemService(IManHinhTapTinDinhKemRepository ManHinhTapTinDinhKemRepository) : base(ManHinhTapTinDinhKemRepository)
    {
    _ManHinhTapTinDinhKemRepository = ManHinhTapTinDinhKemRepository;
    }
    }
    }

