namespace Service_eHospital_DongNai_A.Implement
{
    public class ThuPhanUngThuocCoHaiService : BaseService<ThuPhanUngThuocCoHai, IThuPhanUngThuocCoHaiRepository>
    , IThuPhanUngThuocCoHaiService
    {
    private readonly IThuPhanUngThuocCoHaiRepository _ThuPhanUngThuocCoHaiRepository;
    public ThuPhanUngThuocCoHaiService(IThuPhanUngThuocCoHaiRepository ThuPhanUngThuocCoHaiRepository) : base(ThuPhanUngThuocCoHaiRepository)
    {
    _ThuPhanUngThuocCoHaiRepository = ThuPhanUngThuocCoHaiRepository;
    }
    }
    }

