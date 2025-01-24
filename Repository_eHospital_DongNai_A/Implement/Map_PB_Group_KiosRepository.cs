namespace Repository_eHospital_DongNai_A.Implement
{
    public class Map_PB_Group_KiosRepository : BaseRepository<Map_PB_Group_Kios>
    , IMap_PB_Group_KiosRepository
    {
    private readonly Context _context;
    public Map_PB_Group_KiosRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

