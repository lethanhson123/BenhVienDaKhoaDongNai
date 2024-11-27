namespace Service.Implement
{
    public class DanhMucPhongKhamService : BaseService<DanhMucPhongKham, IDanhMucPhongKhamRepository>
    , IDanhMucPhongKhamService
    {
        private readonly IDanhMucPhongKhamRepository _DanhMucPhongKhamRepository;

        private readonly IDanhMucKhuVucRepository _DanhMucKhuVucRepository;

        private readonly IDanhMucKhoaChuyenMonRepository _DanhMucKhoaChuyenMonRepository;
        public DanhMucPhongKhamService(IDanhMucPhongKhamRepository DanhMucPhongKhamRepository

            , IDanhMucKhuVucRepository DanhMucKhuVucRepository

            , IDanhMucKhoaChuyenMonRepository danhMucKhoaChuyenMonRepository
            
            ) : base(DanhMucPhongKhamRepository)
        {
            _DanhMucPhongKhamRepository = DanhMucPhongKhamRepository;
            _DanhMucKhuVucRepository = DanhMucKhuVucRepository;
            _DanhMucKhoaChuyenMonRepository = danhMucKhoaChuyenMonRepository;
        }

        public override void Initialization(DanhMucPhongKham model)
        {
            BaseInitialization(model);

            if (model.ParentID > 0)
            {
                model.ParentName = _DanhMucKhuVucRepository.GetByID(model.ParentID.Value).Name;
            }

            if (model.DanhMucKhoaChuyenMonID > 0)
            {
                model.DanhMucKhoaChuyenMonName = _DanhMucKhoaChuyenMonRepository.GetByID(model.DanhMucKhoaChuyenMonID.Value).Name;
            }
        }
        public virtual async Task<List<DanhMucPhongKham>> GetSQLByParentIDToListAsync(long ParentID)
        {
            List<DanhMucPhongKham> result = new List<DanhMucPhongKham>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@ParentID",ParentID),                    
            };
            result = await GetByStoredProcedureToListAsync("sp_DanhMucPhongKhamSelectItemsByParentID", parameters);
            return result;
        }
        public virtual async Task<List<DanhMucPhongKham>> GetSQLBySearchStringViaIDToListAsync(string SearchString)
        {
            List<DanhMucPhongKham> result = new List<DanhMucPhongKham>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@SearchString",SearchString),
            };
            result = await GetByStoredProcedureToListAsync("sp_DanhMucPhongKhamSelectItemsBySearchStringViaID", parameters);
            return result;
        }
        public virtual async Task<List<DanhMucPhongKham>> GetSQLBySearchStringViaNameToListAsync(string SearchString)
        {
            List<DanhMucPhongKham> result = new List<DanhMucPhongKham>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@SearchString",SearchString),
            };
            result = await GetByStoredProcedureToListAsync("sp_DanhMucPhongKhamSelectItemsBySearchStringViaName", parameters);
            return result;
        }
    }
}

