namespace Service_eHospital_DongNai_A.Implement
{
    public class TiepNhanService : BaseService<TiepNhan, ITiepNhanRepository>
    , ITiepNhanService
    {
        private readonly ITiepNhanRepository _TiepNhanRepository;
        private readonly IDM_BenhNhanService _DM_BenhNhanService;
        public TiepNhanService(ITiepNhanRepository TiepNhanRepository

            , IDM_BenhNhanService dM_BenhNhanService

        ) : base(TiepNhanRepository)
        {
            _TiepNhanRepository = TiepNhanRepository;
            _DM_BenhNhanService = dM_BenhNhanService;
        }
        public virtual async Task<TiepNhan> GetByTiepNhan_IdAsync(int TiepNhan_Id)
        {
            TiepNhan result = new TiepNhan();
            result = await GetByCondition(item => item.TiepNhan_Id == TiepNhan_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new TiepNhan();
            }
            return result;
        }
        public override async Task<List<TiepNhan>> GetBySearchStringToListAsync(string searchString)
        {
            List<TiepNhan> result = new List<TiepNhan>();
            try
            {
                if (!string.IsNullOrEmpty(searchString))
                {
                    searchString = searchString.Trim();
                    result = await GetByCondition(item => item.SoBHYT.Contains(searchString)).ToListAsync();
                    if (result.Count == GlobalHelper.InitializationNumber)
                    {
                        List<DM_BenhNhan> ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.MaYTe.Contains(searchString)).ToListAsync();
                        if (ListDM_BenhNhan.Count == GlobalHelper.InitializationNumber)
                        {
                            ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.CMND.Contains(searchString)).ToListAsync();
                        }
                        if (ListDM_BenhNhan.Count == GlobalHelper.InitializationNumber)
                        {
                            ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.SoDienThoai.Contains(searchString)).ToListAsync();
                        }
                        if (ListDM_BenhNhan.Count == GlobalHelper.InitializationNumber)
                        {
                            ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.SoBHXH.Contains(searchString)).ToListAsync();
                        }
                        if (ListDM_BenhNhan.Count == GlobalHelper.InitializationNumber)
                        {
                            ListDM_BenhNhan = await _DM_BenhNhanService.GetByCondition(item => item.TenBenhNhan.Contains(searchString)).ToListAsync();
                        }
                        if (ListDM_BenhNhan.Count > 0)
                        {
                            List<int> ListDM_BenhNhanID = ListDM_BenhNhan.Select(item => item.BenhNhan_Id).ToList();
                            foreach (var ID in ListDM_BenhNhanID)
                            {
                                try
                                {
                                    TiepNhan TiepNhan = await GetByCondition(item => item.BenhNhan_Id == ID).FirstOrDefaultAsync();
                                    if (TiepNhan != null)
                                    {
                                        if (TiepNhan.TiepNhan_Id != null)
                                        {
                                            if (TiepNhan.TiepNhan_Id > 0)
                                            {
                                                result.Add(TiepNhan);
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    string message = ex.Message;
                                }
                            }
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
                result = new List<TiepNhan>();
            }
            return result;
        }
        public virtual async Task<List<TiepNhan>> GetByNgayTiepNhanToListAsync(DateTime NgayTiepNhan)
        {
            List<TiepNhan> result = new List<TiepNhan>();
            result = await GetByCondition(item => item.NgayTiepNhan.Value.Year == NgayTiepNhan.Year && item.NgayTiepNhan.Value.Month == NgayTiepNhan.Month && item.NgayTiepNhan.Value.Day == NgayTiepNhan.Day).ToListAsync();
            if (result == null)
            {
                result = new List<TiepNhan>();
            }
            return result;
        }
        public virtual async Task<List<TiepNhan>> GetByNgayTiepNhan_SearchStringToListAsync(DateTime NgayTiepNhan, string SearchString)
        {
            List<TiepNhan> result = new List<TiepNhan>();
            if (!string.IsNullOrEmpty(SearchString))
            {
                result = await GetBySearchStringToListAsync(SearchString);
            }
            else
            {
                result = await GetByNgayTiepNhanToListAsync(NgayTiepNhan);
            }
            if (result == null)
            {
                result = new List<TiepNhan>();
            }
            return result;
        }
    }
}

