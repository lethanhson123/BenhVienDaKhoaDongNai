namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnNgoaiTruService : BaseService<BenhAnNgoaiTru, IBenhAnNgoaiTruRepository>
    , IBenhAnNgoaiTruService
    {
    private readonly IBenhAnNgoaiTruRepository _BenhAnNgoaiTruRepository;
    public BenhAnNgoaiTruService(IBenhAnNgoaiTruRepository BenhAnNgoaiTruRepository) : base(BenhAnNgoaiTruRepository)
    {
    _BenhAnNgoaiTruRepository = BenhAnNgoaiTruRepository;
    }
    }
    }

