namespace Repository_eHospital_DongNai_A.Implement
{
    public class ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository : BaseRepository<ThuPhanUngThuocCoHai_ThuocGayNghiNgoADR>
    , IThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository
    {
    private readonly Context _context;
    public ThuPhanUngThuocCoHai_ThuocGayNghiNgoADRRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

