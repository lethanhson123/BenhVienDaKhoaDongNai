namespace Service_eHospital_DongNai_A.Implement
{
    public class ThuPhanUngThuocCoHai_ThuocSuDungDongThoiService : BaseService<ThuPhanUngThuocCoHai_ThuocSuDungDongThoi, IThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository>
    , IThuPhanUngThuocCoHai_ThuocSuDungDongThoiService
    {
    private readonly IThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository _ThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository;
    public ThuPhanUngThuocCoHai_ThuocSuDungDongThoiService(IThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository ThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository) : base(ThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository)
    {
    _ThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository = ThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository;
    }
    }
    }

