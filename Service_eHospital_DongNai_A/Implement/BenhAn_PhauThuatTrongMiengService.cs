namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAn_PhauThuatTrongMiengService : BaseService<BenhAn_PhauThuatTrongMieng, IBenhAn_PhauThuatTrongMiengRepository>
    , IBenhAn_PhauThuatTrongMiengService
    {
    private readonly IBenhAn_PhauThuatTrongMiengRepository _BenhAn_PhauThuatTrongMiengRepository;
    public BenhAn_PhauThuatTrongMiengService(IBenhAn_PhauThuatTrongMiengRepository BenhAn_PhauThuatTrongMiengRepository) : base(BenhAn_PhauThuatTrongMiengRepository)
    {
    _BenhAn_PhauThuatTrongMiengRepository = BenhAn_PhauThuatTrongMiengRepository;
    }
    }
    }

