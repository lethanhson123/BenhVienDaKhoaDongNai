namespace Repository_eHospital_DongNai_A.Implement
{
    public class KSK_DM_NhomDoiTuong_DichVuRepository : BaseRepository<KSK_DM_NhomDoiTuong_DichVu>
    , IKSK_DM_NhomDoiTuong_DichVuRepository
    {
    private readonly Context _context;
    public KSK_DM_NhomDoiTuong_DichVuRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

