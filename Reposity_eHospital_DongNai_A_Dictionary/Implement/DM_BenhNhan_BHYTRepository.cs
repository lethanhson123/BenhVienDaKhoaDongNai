namespace Repository_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_BenhNhan_BHYTRepository : BaseRepository<DM_BenhNhan_BHYT>
    , IDM_BenhNhan_BHYTRepository
    {
        private readonly Context _context;
        public DM_BenhNhan_BHYTRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}

