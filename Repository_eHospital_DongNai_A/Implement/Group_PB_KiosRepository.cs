namespace Repository_eHospital_DongNai_A.Implement
{
    public class Group_PB_KiosRepository : BaseRepository<Group_PB_Kios>
    , IGroup_PB_KiosRepository
    {
    private readonly Context _context;
    public Group_PB_KiosRepository(Context context) : base(context)
    {
    _context = context;
    }
    }
    }

