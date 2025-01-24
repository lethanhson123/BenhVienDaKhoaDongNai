namespace Service_eHospital_DongNai_A.Implement
{
    public class DuocTonKho_BookNoiTruService : BaseService<DuocTonKho_BookNoiTru, IDuocTonKho_BookNoiTruRepository>
    , IDuocTonKho_BookNoiTruService
    {
    private readonly IDuocTonKho_BookNoiTruRepository _DuocTonKho_BookNoiTruRepository;
    public DuocTonKho_BookNoiTruService(IDuocTonKho_BookNoiTruRepository DuocTonKho_BookNoiTruRepository) : base(DuocTonKho_BookNoiTruRepository)
    {
    _DuocTonKho_BookNoiTruRepository = DuocTonKho_BookNoiTruRepository;
    }
    }
    }

