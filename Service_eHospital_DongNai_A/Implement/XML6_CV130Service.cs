﻿namespace Service_eHospital_DongNai_A.Implement
{
    public class XML6_CV130Service : BaseService<XML6_CV130, IXML6_CV130Repository>
    , IXML6_CV130Service
    {
        private readonly IXML6_CV130Repository _XML6_CV130Repository;
        public XML6_CV130Service(IXML6_CV130Repository XML6_CV130Repository) : base(XML6_CV130Repository)
        {
            _XML6_CV130Repository = XML6_CV130Repository;
        }
        public override async Task<XML6_CV130> SaveAsync(XML6_CV130 model)
        {
            if (model.XML6_CV130_Id > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            return model;
        }
        public override async Task<XML6_CV130> GetByIDAsync(int ID)
        {
            XML6_CV130 result = new XML6_CV130();
            result = await GetByCondition(item => item.XML6_CV130_Id == ID).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new XML6_CV130();
            }
            return result;
        }
        public override async Task<List<XML6_CV130>> GetBySearchStringToListAsync(string searchString)
        {
            List<XML6_CV130> result = new List<XML6_CV130>();
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
                result = new List<XML6_CV130>();
            }
            return result;
        }
        public virtual async Task<List<XML6_CV130>> GetByListIDStringToListAsync(List<string> ListIDString)
        {
            List<XML6_CV130> result = new List<XML6_CV130>();
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
                result = new List<XML6_CV130>();
            }
            return result;
        }
        public virtual async Task<List<XML6_CV130>> GetByYear_Month_SearchStringToListAsync(int Year, int Month, string SearchString)
        {
            List<XML6_CV130> result = new List<XML6_CV130>();
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
                result = new List<XML6_CV130>();
            }
            return result;
        }
    }
}

