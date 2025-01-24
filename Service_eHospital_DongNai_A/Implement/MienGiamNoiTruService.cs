namespace Service_eHospital_DongNai_A.Implement
{
    public class MienGiamNoiTruService : BaseService<MienGiamNoiTru, IMienGiamNoiTruRepository>
    , IMienGiamNoiTruService
    {
    private readonly IMienGiamNoiTruRepository _MienGiamNoiTruRepository;
    public MienGiamNoiTruService(IMienGiamNoiTruRepository MienGiamNoiTruRepository) : base(MienGiamNoiTruRepository)
    {
    _MienGiamNoiTruRepository = MienGiamNoiTruRepository;
    }
    }
    }

