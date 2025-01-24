namespace Service_eHospital_DongNai_A.Implement
{
    public class KhamSucKhoeChiTietService : BaseService<KhamSucKhoeChiTiet, IKhamSucKhoeChiTietRepository>
    , IKhamSucKhoeChiTietService
    {
    private readonly IKhamSucKhoeChiTietRepository _KhamSucKhoeChiTietRepository;
    public KhamSucKhoeChiTietService(IKhamSucKhoeChiTietRepository KhamSucKhoeChiTietRepository) : base(KhamSucKhoeChiTietRepository)
    {
    _KhamSucKhoeChiTietRepository = KhamSucKhoeChiTietRepository;
    }
    }
    }

