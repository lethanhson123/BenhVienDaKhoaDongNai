namespace Service_eHospital_DongNai_A.Implement
{
    public class ThongTinDieuTriHIVService : BaseService<ThongTinDieuTriHIV, IThongTinDieuTriHIVRepository>
    , IThongTinDieuTriHIVService
    {
    private readonly IThongTinDieuTriHIVRepository _ThongTinDieuTriHIVRepository;
    public ThongTinDieuTriHIVService(IThongTinDieuTriHIVRepository ThongTinDieuTriHIVRepository) : base(ThongTinDieuTriHIVRepository)
    {
    _ThongTinDieuTriHIVRepository = ThongTinDieuTriHIVRepository;
    }
    }
    }

