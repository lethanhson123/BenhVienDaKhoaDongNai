namespace Repository_eHospital_DongNai_A.Implement
{
    public class DinhNghiaTuDienVietAnhRepository : BaseRepository<DinhNghiaTuDienVietAnh>
    , IDinhNghiaTuDienVietAnhRepository
    {
    private readonly Context _context;
    public DinhNghiaTuDienVietAnhRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

