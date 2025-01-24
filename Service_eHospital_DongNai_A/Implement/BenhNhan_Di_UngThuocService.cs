namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhNhan_Di_UngThuocService : BaseService<BenhNhan_Di_UngThuoc, IBenhNhan_Di_UngThuocRepository>
    , IBenhNhan_Di_UngThuocService
    {
    private readonly IBenhNhan_Di_UngThuocRepository _BenhNhan_Di_UngThuocRepository;
    public BenhNhan_Di_UngThuocService(IBenhNhan_Di_UngThuocRepository BenhNhan_Di_UngThuocRepository) : base(BenhNhan_Di_UngThuocRepository)
    {
    _BenhNhan_Di_UngThuocRepository = BenhNhan_Di_UngThuocRepository;
    }
    }
    }

