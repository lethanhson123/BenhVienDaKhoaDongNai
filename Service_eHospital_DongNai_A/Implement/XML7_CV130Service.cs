namespace Service_eHospital_DongNai_A.Implement
{
    public class XML7_CV130Service : BaseService<XML7_CV130, IXML7_CV130Repository>
    , IXML7_CV130Service
    {
        private readonly IXML7_CV130Repository _XML7_CV130Repository;
        public XML7_CV130Service(IXML7_CV130Repository XML7_CV130Repository) : base(XML7_CV130Repository)
        {
            _XML7_CV130Repository = XML7_CV130Repository;
        }
        public override async Task<List<XML7_CV130>> GetBySearchStringToListAsync(string searchString)
        {
            List<XML7_CV130> result = new List<XML7_CV130>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    result = await GetByCondition(item => item.TiepNhan_Id.Value.ToString() == searchString).ToListAsync();
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.BenhAn_Id.Value.ToString() == searchString).ToListAsync();
                    }
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.XacNhanChiPhi_Id.Value.ToString() == searchString).ToListAsync();
                    }
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.MA_LK.Trim() == searchString).ToListAsync();
                    }
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.SO_LUU_TRU.Trim() == searchString).ToListAsync();
                    }
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        result = await GetByCondition(item => item.MA_YTE.Trim() == searchString).ToListAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (result == null)
            {
                result = new List<XML7_CV130>();
            }
            return result;
        }
        public virtual async Task<List<XML7_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString)
        {
            List<XML7_CV130> result = new List<XML7_CV130>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                SearchString = Year.ToString();
                if (Month > 0)
                {
                    if (Month > 9)
                    {
                        SearchString = SearchString + Month.ToString();
                    }
                    else
                    {
                        SearchString = SearchString + "0" + Month.ToString();
                    }
                }
                result = await GetByCondition(item => item.NGAY_CT.Trim().Contains(SearchString)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<XML7_CV130>();
            }
            return result;
        }
    }
}

