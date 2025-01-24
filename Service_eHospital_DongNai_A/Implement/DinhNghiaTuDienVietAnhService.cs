namespace Service_eHospital_DongNai_A.Implement
{
    public class DinhNghiaTuDienVietAnhService : BaseService<DinhNghiaTuDienVietAnh, IDinhNghiaTuDienVietAnhRepository>
    , IDinhNghiaTuDienVietAnhService
    {
    private readonly IDinhNghiaTuDienVietAnhRepository _DinhNghiaTuDienVietAnhRepository;
    public DinhNghiaTuDienVietAnhService(IDinhNghiaTuDienVietAnhRepository DinhNghiaTuDienVietAnhRepository) : base(DinhNghiaTuDienVietAnhRepository)
    {
    _DinhNghiaTuDienVietAnhRepository = DinhNghiaTuDienVietAnhRepository;
    }
    }
    }

