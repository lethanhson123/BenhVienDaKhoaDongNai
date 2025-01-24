namespace Service_eHospital_DongNai_A.Implement
{
    public class ThuPhanUngThuocService : BaseService<ThuPhanUngThuoc, IThuPhanUngThuocRepository>
    , IThuPhanUngThuocService
    {
    private readonly IThuPhanUngThuocRepository _ThuPhanUngThuocRepository;
    public ThuPhanUngThuocService(IThuPhanUngThuocRepository ThuPhanUngThuocRepository) : base(ThuPhanUngThuocRepository)
    {
    _ThuPhanUngThuocRepository = ThuPhanUngThuocRepository;
    }
    }
    }

