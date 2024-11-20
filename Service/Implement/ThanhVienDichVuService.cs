namespace Service.Implement
{
    public class ThanhVienDichVuService : BaseService<ThanhVienDichVu, IThanhVienDichVuRepository>
    , IThanhVienDichVuService
    {
        private readonly IThanhVienDichVuRepository _ThanhVienDichVuRepository;
        public ThanhVienDichVuService(IThanhVienDichVuRepository ThanhVienDichVuRepository) : base(ThanhVienDichVuRepository)
        {
            _ThanhVienDichVuRepository = ThanhVienDichVuRepository;
        }
        public virtual async Task<List<ThanhVienDichVu>> GetSQLByParentIDToListAsync(long ParentID)
        {
            List<ThanhVienDichVu> result = new List<ThanhVienDichVu>();
            SqlParameter[] parameters =
            {
                    new SqlParameter("@ParentID",ParentID),
            };
            result = await GetByStoredProcedureToListAsync("sp_ThanhVienDichVuSelectItemsByParentID", parameters);
            return result;
        }
    }
}

