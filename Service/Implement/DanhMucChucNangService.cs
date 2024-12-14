namespace Service.Implement
{
    public class DanhMucChucNangService : BaseService<DanhMucChucNang, IDanhMucChucNangRepository>
    , IDanhMucChucNangService
    {
        private readonly IDanhMucChucNangRepository _DanhMucChucNangRepository;

        private readonly IThanhVienChucNangRepository _ThanhVienChucNangRepository;
        public DanhMucChucNangService(IDanhMucChucNangRepository DanhMucChucNangRepository

            , IThanhVienChucNangRepository thanhVienChucNangRepository

            ) : base(DanhMucChucNangRepository)
        {
            _DanhMucChucNangRepository = DanhMucChucNangRepository;
            _ThanhVienChucNangRepository = thanhVienChucNangRepository;
        }
        public override void Initialization(DanhMucChucNang model)
        {
            BaseInitialization(model);
            if (string.IsNullOrEmpty(model.Code))
            {
                model.Code = "#";
            }
        }
        public virtual async Task<List<DanhMucChucNang>> GetSQLByThanhVienID_ActiveToListAsync(long ThanhVienID, bool Active)
        {
            List<DanhMucChucNang> result = new List<DanhMucChucNang>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@ThanhVienID",ThanhVienID),
                    new SqlParameter("@Active",Active),
            };
            result = await GetByStoredProcedureToListAsync("sp_DanhMucChucNangSelectItemsByThanhVienID_Active", parameters);
            return result;
        }
        public virtual async Task<List<DanhMucChucNang>> GetByThanhVienID_ActiveToListAsync(long ThanhVienID, bool Active)
        {
            List<DanhMucChucNang> result = new List<DanhMucChucNang>();
            List<long> ListThanhVienChucNangID = await _ThanhVienChucNangRepository.GetByCondition(item => item.ParentID == ThanhVienID && item.Active == Active).Select(item => item.DanhMucChucNangID.Value).ToListAsync();
            result = await GetByCondition(item => item.Active == Active && ListThanhVienChucNangID.Contains(item.ID)).ToListAsync();
            if (result == null)
            {
                result = new List<DanhMucChucNang>();
            }
            return result;
        }
    }
}

