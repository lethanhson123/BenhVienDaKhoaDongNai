namespace Repository_eHospital_DongNai_A.Implement
{
    public class GiaiPhauBenhSinhThiet_KetQuaRepository : BaseRepository<GiaiPhauBenhSinhThiet_KetQua>
    , IGiaiPhauBenhSinhThiet_KetQuaRepository
    {
    private readonly Context _context;
    public GiaiPhauBenhSinhThiet_KetQuaRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

