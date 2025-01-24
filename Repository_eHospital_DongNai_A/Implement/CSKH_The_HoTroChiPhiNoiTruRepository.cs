namespace Repository_eHospital_DongNai_A.Implement
{
    public class CSKH_The_HoTroChiPhiNoiTruRepository : BaseRepository<CSKH_The_HoTroChiPhiNoiTru>
    , ICSKH_The_HoTroChiPhiNoiTruRepository
    {
    private readonly Context _context;
    public CSKH_The_HoTroChiPhiNoiTruRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

