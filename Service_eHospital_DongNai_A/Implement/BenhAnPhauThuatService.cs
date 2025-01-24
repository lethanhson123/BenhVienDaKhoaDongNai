namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnPhauThuatService : BaseService<BenhAnPhauThuat, IBenhAnPhauThuatRepository>
    , IBenhAnPhauThuatService
    {
    private readonly IBenhAnPhauThuatRepository _BenhAnPhauThuatRepository;
    public BenhAnPhauThuatService(IBenhAnPhauThuatRepository BenhAnPhauThuatRepository) : base(BenhAnPhauThuatRepository)
    {
    _BenhAnPhauThuatRepository = BenhAnPhauThuatRepository;
    }
    }
    }

