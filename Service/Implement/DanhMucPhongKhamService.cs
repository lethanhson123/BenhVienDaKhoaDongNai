namespace Service.Implement
{
    public class DanhMucPhongKhamService : BaseService<DanhMucPhongKham, IDanhMucPhongKhamRepository>
    , IDanhMucPhongKhamService
    {
    private readonly IDanhMucPhongKhamRepository _DanhMucPhongKhamRepository;
    public DanhMucPhongKhamService(IDanhMucPhongKhamRepository DanhMucPhongKhamRepository) : base(DanhMucPhongKhamRepository)
    {
    _DanhMucPhongKhamRepository = DanhMucPhongKhamRepository;
    }
    }
    }

