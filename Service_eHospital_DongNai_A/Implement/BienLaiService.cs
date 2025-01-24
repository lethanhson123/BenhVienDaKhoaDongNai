namespace Service_eHospital_DongNai_A.Implement
{
    public class BienLaiService : BaseService<BienLai, IBienLaiRepository>
    , IBienLaiService
    {
    private readonly IBienLaiRepository _BienLaiRepository;
    public BienLaiService(IBienLaiRepository BienLaiRepository) : base(BienLaiRepository)
    {
    _BienLaiRepository = BienLaiRepository;
    }
    }
    }

