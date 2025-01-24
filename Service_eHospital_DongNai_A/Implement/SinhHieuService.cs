namespace Service_eHospital_DongNai_A.Implement
{
    public class SinhHieuService : BaseService<SinhHieu, ISinhHieuRepository>
    , ISinhHieuService
    {
    private readonly ISinhHieuRepository _SinhHieuRepository;
    public SinhHieuService(ISinhHieuRepository SinhHieuRepository) : base(SinhHieuRepository)
    {
    _SinhHieuRepository = SinhHieuRepository;
    }
    }
    }

