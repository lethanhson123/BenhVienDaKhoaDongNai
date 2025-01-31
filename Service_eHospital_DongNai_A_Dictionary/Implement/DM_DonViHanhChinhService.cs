namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class DM_DonViHanhChinhService : BaseService<DM_DonViHanhChinh, IDM_DonViHanhChinhRepository>
    , IDM_DonViHanhChinhService
    {
        private readonly IDM_DonViHanhChinhRepository _DM_DonViHanhChinhRepository;
        public DM_DonViHanhChinhService(IDM_DonViHanhChinhRepository DM_DonViHanhChinhRepository) : base(DM_DonViHanhChinhRepository)
        {
            _DM_DonViHanhChinhRepository = DM_DonViHanhChinhRepository;
        }
        public override async Task<DM_DonViHanhChinh> SaveAsync(DM_DonViHanhChinh model)
        {
            if (model.DonViHanhChinh_Id > 0)
            {
                await UpdateAsync(model);
            }
            else
            {
                await AddAsync(model);
            }
            return model;
        }
        public override async Task<List<DM_DonViHanhChinh>> GetBySearchStringToListAsync(string searchString)
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            if (!string.IsNullOrEmpty(searchString))
            {
                result = await GetByCondition(item => item.DonViHanhChinh_Id.Value.ToString().Contains(searchString)).ToListAsync();
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.MaDonVi.Contains(searchString)).ToListAsync();
                }
                if (result.Count == GlobalHelper.InitializationNumber)
                {
                    result = await GetByCondition(item => item.TenDonVi.Contains(searchString)).ToListAsync();
                }
            }
            else
            {
                result = await GetByCondition(item => 1 == 1).Take(19).ToListAsync();
            }
            if (result == null)
            {
                result = new List<DM_DonViHanhChinh>();
            }
            return result;
        }
        public override async Task<List<DM_DonViHanhChinh>> GetBySearchStringAndEmptyToListAsync(string SearchString)
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                DM_DonViHanhChinh empty = new DM_DonViHanhChinh();
                result.Add(empty);
                List<DM_DonViHanhChinh> list = await GetBySearchStringToListAsync(SearchString);
                if (list.Count > 0)
                {
                    result.AddRange(list);
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<DM_DonViHanhChinh>> GetByCapDonViToListAsync(int CapDonVi)
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                if (CapDonVi > 0)
                {
                    List<DM_DonViHanhChinh> list = await GetByCondition(item => item.CapDonVi == CapDonVi).ToListAsync();
                    if (list.Count > 0)
                    {
                        result.AddRange(list);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            if (result == null)
            {
                result = new List<DM_DonViHanhChinh>();
            }
            return result;
        }
        public virtual async Task<List<DM_DonViHanhChinh>> GetByCapDonViAndEmptyToListAsync(int CapDonVi)
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                DM_DonViHanhChinh empty = new DM_DonViHanhChinh();
                result.Add(empty);
                if (CapDonVi > 0)
                {
                    List<DM_DonViHanhChinh> list = await GetByCondition(item => item.CapDonVi == CapDonVi).ToListAsync();
                    if (list.Count > 0)
                    {
                        result.AddRange(list);
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return result;
        }
        public virtual async Task<List<DM_DonViHanhChinh>> GetByCapDonVi_CapTren_IdToListAsync(int CapDonVi, int CapTren_Id)
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                if (CapDonVi > 0)
                {
                    if (CapTren_Id > 0)
                    {
                        List<DM_DonViHanhChinh> list = await GetByCondition(item => item.CapDonVi == CapDonVi && item.CapTren_Id == CapTren_Id).ToListAsync();
                        if (list.Count > 0)
                        {
                            result.AddRange(list);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            if (result == null)
            {
                result = new List<DM_DonViHanhChinh>();
            }
            return result;
        }
        public virtual async Task<List<DM_DonViHanhChinh>> GetByCapDonVi_CapTren_IdAndEmptyToListAsync(int CapDonVi, int CapTren_Id)
        {
            List<DM_DonViHanhChinh> result = new List<DM_DonViHanhChinh>();
            try
            {
                DM_DonViHanhChinh empty = new DM_DonViHanhChinh();
                result.Add(empty);
                if (CapDonVi > 0)
                {
                    if (CapTren_Id > 0)
                    {
                        List<DM_DonViHanhChinh> list = await GetByCondition(item => item.CapDonVi == CapDonVi && item.CapTren_Id == CapTren_Id).ToListAsync();
                        if (list.Count > 0)
                        {
                            result.AddRange(list);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return result;
        }
    }
}

