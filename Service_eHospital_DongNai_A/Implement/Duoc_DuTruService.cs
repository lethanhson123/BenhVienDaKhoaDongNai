namespace Service_eHospital_DongNai_A.Implement
{
    public class Duoc_DuTruService : BaseService<Duoc_DuTru, IDuoc_DuTruRepository>
    , IDuoc_DuTruService
    {
    private readonly IDuoc_DuTruRepository _Duoc_DuTruRepository;
    public Duoc_DuTruService(IDuoc_DuTruRepository Duoc_DuTruRepository) : base(Duoc_DuTruRepository)
    {
    _Duoc_DuTruRepository = Duoc_DuTruRepository;
    }
    }
    }

