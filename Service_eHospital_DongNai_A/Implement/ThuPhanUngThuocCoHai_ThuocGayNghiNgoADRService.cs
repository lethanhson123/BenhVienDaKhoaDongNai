namespace Service_eHospital_DongNai_A.Implement
{
    public class ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService : BaseService<ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR, IThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository>
    , IThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService
    {
    private readonly IThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository _ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository;
    public ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRService(IThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository) : base(ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository)
    {
    _ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository = ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository;
    }
    }
    }

