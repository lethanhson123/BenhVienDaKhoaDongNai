namespace Service.Implement
{
    public class DanhMucToChucDaoTaoService : BaseService<DanhMucToChucDaoTao, IDanhMucToChucDaoTaoRepository>
    , IDanhMucToChucDaoTaoService
    {
    private readonly IDanhMucToChucDaoTaoRepository _DanhMucToChucDaoTaoRepository;
    public DanhMucToChucDaoTaoService(IDanhMucToChucDaoTaoRepository DanhMucToChucDaoTaoRepository) : base(DanhMucToChucDaoTaoRepository)
    {
    _DanhMucToChucDaoTaoRepository = DanhMucToChucDaoTaoRepository;
    }
    }
    }

