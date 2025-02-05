namespace Service_eHospital_DongNai_A.Implement
{
    public class BenhAnService : BaseService<BenhAn, IBenhAnRepository>
    , IBenhAnService
    {
        private readonly IBenhAnRepository _BenhAnRepository;
        public BenhAnService(IBenhAnRepository BenhAnRepository) : base(BenhAnRepository)
        {
            _BenhAnRepository = BenhAnRepository;
        }
        public virtual async Task<BenhAn> GetByBenhAn_IdAsync(int BenhAn_Id)
        {
            BenhAn result = new BenhAn();
            result = await GetByCondition(item => item.BenhAn_Id == BenhAn_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new BenhAn();
            }
            return result;
        }
        public override async Task<List<BenhAn>> GetBySearchStringToListAsync(string searchString)
        {
            List<BenhAn> result = new List<BenhAn>();
            if (!string.IsNullOrEmpty(searchString))
            {
                searchString = searchString.Trim();
                result = await GetByCondition(item => item.SoBenhAn.Contains(searchString)).ToListAsync();
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.SoLuuTru.Contains(searchString)).ToListAsync();
                }
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.SoCapCuu.Contains(searchString)).ToListAsync();
                }
            }
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByNgayVaoVienToListAsync(DateTime NgayVaoVien)
        {
            List<BenhAn> result = new List<BenhAn>();
            result = await GetByCondition(item => item.NgayVaoVien.Value.Year == NgayVaoVien.Year && item.NgayVaoVien.Value.Month == NgayVaoVien.Month && item.NgayVaoVien.Value.Day == NgayVaoVien.Day).ToListAsync();
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByKhoaVao_IdToListAsync(int PhongBan_Id)
        {
            List<BenhAn> result = new List<BenhAn>();
            result = await GetByCondition(item => item.KhoaVao_Id == PhongBan_Id).ToListAsync();
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
        public virtual async Task<List<BenhAn>> GetByNgayVaoVien_SearchStringToListAsync(DateTime NgayVaoVien, string SearchString)
        {
            List<BenhAn> result = new List<BenhAn>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                result = await GetByNgayVaoVienToListAsync(NgayVaoVien);
            }
            if (result == null)
            {
                result = new List<BenhAn>();
            }
            return result;
        }
    }
}

