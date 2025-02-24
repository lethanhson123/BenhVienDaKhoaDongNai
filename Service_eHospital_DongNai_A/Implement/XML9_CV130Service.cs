using System.Collections.Generic;

namespace Service_eHospital_DongNai_A.Implement
{
    public class XML9_CV130Service : BaseService<XML9_CV130, IXML9_CV130Repository>
    , IXML9_CV130Service
    {
        private readonly IXML9_CV130Repository _XML9_CV130Repository;

        private readonly ITiepNhanService _TiepNhanService;
        public XML9_CV130Service(IXML9_CV130Repository XML9_CV130Repository

            , ITiepNhanService TiepNhanService

        ) : base(XML9_CV130Repository)
        {
            _XML9_CV130Repository = XML9_CV130Repository;
            _TiepNhanService = TiepNhanService;
        }
        public override async Task<List<XML9_CV130>> GetBySearchStringToListAsync(string searchString)
        {
            List<XML9_CV130> result = new List<XML9_CV130>();
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
                result = new List<XML9_CV130>();
            }
            return result;
        }
        public virtual async Task<List<XML9_CV130>> GetByListIDStringToListAsync(List<string> ListIDString)
        {
            List<XML9_CV130> result = new List<XML9_CV130>();
            try
            {
                if (ListIDString.Count > 0)
                {
                    result = await GetByCondition(item => EF.Constant(ListIDString).Contains(item.MA_LK.Trim())).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            if (result == null)
            {
                result = new List<XML9_CV130>();
            }
            return result;
        }
        public virtual async Task<List<XML9_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString)
        {
            List<XML9_CV130> result = new List<XML9_CV130>();
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
                result = new List<XML9_CV130>();
            }
            return result;
        }
    }
}

