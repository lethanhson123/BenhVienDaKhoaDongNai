namespace Service_eHospital_DongNai_A.Implement
{
    public class ThongTinCapCuuService : BaseService<ThongTinCapCuu, IThongTinCapCuuRepository>
    , IThongTinCapCuuService
    {
    private readonly IThongTinCapCuuRepository _ThongTinCapCuuRepository;
    public ThongTinCapCuuService(IThongTinCapCuuRepository ThongTinCapCuuRepository) : base(ThongTinCapCuuRepository)
    {
    _ThongTinCapCuuRepository = ThongTinCapCuuRepository;
    }
    }
    }

