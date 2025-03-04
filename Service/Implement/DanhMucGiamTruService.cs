namespace Service.Implement
{
    public class DanhMucGiamTruService : BaseService<DanhMucGiamTru, IDanhMucGiamTruRepository>
    , IDanhMucGiamTruService
    {
    private readonly IDanhMucGiamTruRepository _DanhMucGiamTruRepository;
    public DanhMucGiamTruService(IDanhMucGiamTruRepository DanhMucGiamTruRepository) : base(DanhMucGiamTruRepository)
    {
    _DanhMucGiamTruRepository = DanhMucGiamTruRepository;
    }
    }
    }

