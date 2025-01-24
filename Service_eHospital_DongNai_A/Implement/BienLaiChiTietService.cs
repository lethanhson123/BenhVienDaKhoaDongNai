namespace Service_eHospital_DongNai_A.Implement
{
    public class BienLaiChiTietService : BaseService<BienLaiChiTiet, IBienLaiChiTietRepository>
    , IBienLaiChiTietService
    {
    private readonly IBienLaiChiTietRepository _BienLaiChiTietRepository;
    public BienLaiChiTietService(IBienLaiChiTietRepository BienLaiChiTietRepository) : base(BienLaiChiTietRepository)
    {
    _BienLaiChiTietRepository = BienLaiChiTietRepository;
    }
    }
    }

