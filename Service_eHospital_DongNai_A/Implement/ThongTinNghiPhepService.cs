namespace Service_eHospital_DongNai_A.Implement
{
    public class ThongTinNghiPhepService : BaseService<ThongTinNghiPhep, IThongTinNghiPhepRepository>
    , IThongTinNghiPhepService
    {
    private readonly IThongTinNghiPhepRepository _ThongTinNghiPhepRepository;
    public ThongTinNghiPhepService(IThongTinNghiPhepRepository ThongTinNghiPhepRepository) : base(ThongTinNghiPhepRepository)
    {
    _ThongTinNghiPhepRepository = ThongTinNghiPhepRepository;
    }
    }
    }

