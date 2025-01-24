namespace Repository_eHospital_DongNai_A.Implement
{
    public class XML2Repository : BaseRepository<XML2>
    , IXML2Repository
    {
        private readonly Context _context;
        public XML2Repository(Context context) : base(context)
        {
            _context = context;
        }
    }
}

