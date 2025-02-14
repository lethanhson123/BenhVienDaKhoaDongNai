namespace Service_eHospital_DongNai_A.Implement
{
    public class ChungTuService : BaseService<ChungTu, IChungTuRepository>
    , IChungTuService
    {
        private readonly IChungTuRepository _ChungTuRepository;
        public ChungTuService(IChungTuRepository ChungTuRepository) : base(ChungTuRepository)
        {
            _ChungTuRepository = ChungTuRepository;
        }
        public virtual async Task<ChungTu> GetByChungTu_IdAsync(int ChungTu_Id)
        {
            ChungTu result = new ChungTu();
            result = await GetByCondition(item => item.ChungTu_Id == ChungTu_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new ChungTu();
            }
            return result;
        }
        public override async Task<List<ChungTu>> GetBySearchStringToListAsync(string searchString)
        {
            List<ChungTu> result = new List<ChungTu>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    result = await GetByCondition(item => item.ChungTu_Id.Value.ToString() == searchString).ToListAsync();
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.MaChungTu.Trim().Contains(searchString)).ToListAsync();
                    }                    
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                     
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (result == null)
            {
                result = new List<ChungTu>();
            }
            return result;
        }
        public virtual async Task<List<ChungTu>> GetByNgayChungTuToListAsync(DateTime NgayChungTu)
        {
            List<ChungTu> result = new List<ChungTu>();
            result = await GetByCondition(item => item.NgayChungTu.Value.Year == NgayChungTu.Year && item.NgayChungTu.Value.Month == NgayChungTu.Month && item.NgayChungTu.Value.Day == NgayChungTu.Day).ToListAsync();
            if (result == null)
            {
                result = new List<ChungTu>();
            }
            return result;
        }
        public virtual async Task<List<ChungTu>> GetByNgayChungTu_SearchStringToListAsync(DateTime NgayChungTu, string SearchString)
        {
            List<ChungTu> result = new List<ChungTu>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                result = await GetByNgayChungTuToListAsync(NgayChungTu);
            }
            if (result == null)
            {
                result = new List<ChungTu>();
            }
            return result;
        }
        public virtual async Task<List<ChungTu>> GetByYear_Month_DayToListAsync(int Year, int Month, int Day)
        {
            List<ChungTu> result = new List<ChungTu>();
            result = await GetByCondition(item => item.NgayChungTu.Value.Year == Year && item.NgayChungTu.Value.Month == Month && item.NgayChungTu.Value.Day == Day).ToListAsync();
            if (result == null)
            {
                result = new List<ChungTu>();
            }
            return result;
        }
        public virtual async Task<List<ChungTu>> GetByYear_Month_Day_SearchStringToListAsync(int Year, int Month, int Day, string SearchString)
        {
            List<ChungTu> result = new List<ChungTu>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                result = await GetByYear_Month_DayToListAsync(Year, Month, Day);
            }
            if (result == null)
            {
                result = new List<ChungTu>();
            }
            return result;
        }
    }
}

