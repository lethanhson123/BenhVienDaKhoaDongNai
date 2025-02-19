namespace Service_eHospital_DongNai_A.Implement
{
    public class XML13_CV130Service : BaseService<XML13_CV130, IXML13_CV130Repository>
    , IXML13_CV130Service
    {
        private readonly IXML13_CV130Repository _XML13_CV130Repository;
        public XML13_CV130Service(IXML13_CV130Repository XML13_CV130Repository) : base(XML13_CV130Repository)
        {
            _XML13_CV130Repository = XML13_CV130Repository;
        }
        public override async Task<List<XML13_CV130>> GetBySearchStringToListAsync(string searchString)
        {
            List<XML13_CV130> result = new List<XML13_CV130>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    foreach (string SearchStringSub in searchString.Split(';'))
                    {
                        if (!string.IsNullOrEmpty(SearchStringSub))
                        {
                            result.AddRange(await GetByCondition(item => item.MA_LK.Trim() == SearchStringSub).ToListAsync());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (result == null)
            {
                result = new List<XML13_CV130>();
            }
            return result;
        }
        public virtual async Task<List<XML13_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString)
        {
            List<XML13_CV130> result = new List<XML13_CV130>();
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
                result = await GetByCondition(item => item.MA_LK.Trim().Contains(SearchString)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<XML13_CV130>();
            }
            return result;
        }
    }
}

