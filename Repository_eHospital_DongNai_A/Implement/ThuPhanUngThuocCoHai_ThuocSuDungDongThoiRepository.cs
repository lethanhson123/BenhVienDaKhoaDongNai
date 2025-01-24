namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository : BaseRepository<ThuPhanUngThuocCoHai_ThuocSuDungDongThoi>
    , IThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository
    {
    private readonly Context _context;
    public ThuPhanUngThuocCoHai_ThuocSuDungDongThoiRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

