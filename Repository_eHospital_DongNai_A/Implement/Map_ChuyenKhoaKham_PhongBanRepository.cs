namespace Repository_eHospital_DongNai_A.Implement
{
    public class Map_ChuyenKhoaKham_PhongBanRepository : BaseRepository<Map_ChuyenKhoaKham_PhongBan>
    , IMap_ChuyenKhoaKham_PhongBanRepository
    {
    private readonly Context _context;
    public Map_ChuyenKhoaKham_PhongBanRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

