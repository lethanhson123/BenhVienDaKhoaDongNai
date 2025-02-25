namespace Service_eHospital_DongNai_A.Implement
{
    public class XML12_CV130Service : BaseService<XML12_CV130, IXML12_CV130Repository>
    , IXML12_CV130Service
    {
        private readonly IXML12_CV130Repository _XML12_CV130Repository;
        public XML12_CV130Service(IXML12_CV130Repository XML12_CV130Repository) : base(XML12_CV130Repository)
        {
            _XML12_CV130Repository = XML12_CV130Repository;
        }
        public override async Task<XML12_CV130> SaveAsync(XML12_CV130 model)
        {
            if (model.XML12_CV130_Id > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            return model;
        }
        public override async Task<XML12_CV130> GetByIDAsync(int ID)
        {
            XML12_CV130 result = new XML12_CV130();
            result = await GetByCondition(item => item.XML12_CV130_Id == ID).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new XML12_CV130();
            }
            return result;
        }
        public override async Task<List<XML12_CV130>> GetBySearchStringToListAsync(string searchString)
        {
            List<XML12_CV130> result = new List<XML12_CV130>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    //foreach (string SearchStringSub in searchString.Split(';'))
                    //{
                    //    if (!string.IsNullOrEmpty(SearchStringSub))
                    //    {
                    //        result.AddRange(await GetByCondition(item => item.MA_LK.Trim() == SearchStringSub).ToListAsync());
                    //    }
                    //}
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }

            if (result == null)
            {
                result = new List<XML12_CV130>();
            }
            return result;
        }
        public virtual async Task<List<XML12_CV130>> GetByListIDStringToListAsync(List<string> ListIDString)
        {
            List<XML12_CV130> result = new List<XML12_CV130>();
            try
            {
                if (ListIDString.Count > 0)
                {
                    result = await GetByCondition(item => EF.Constant(ListIDString).Contains(item.MA_DOI_TUONG.Trim())).ToListAsync();
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
            if (result == null)
            {
                result = new List<XML12_CV130>();
            }
            return result;
        }
        public virtual async Task<List<XML12_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString)
        {
            List<XML12_CV130> result = new List<XML12_CV130>();
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
                result = await GetByCondition(item => item.NGAY_HOP.Trim().Contains(SearchString)).ToListAsync();
            }
            if (result == null)
            {
                result = new List<XML12_CV130>();
            }
            return result;
        }
    }
}

