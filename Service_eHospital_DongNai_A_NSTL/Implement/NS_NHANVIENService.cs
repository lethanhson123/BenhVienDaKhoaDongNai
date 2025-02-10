namespace Service_eHospital_DongNai_A_NSTL.Implement
{
    public class NS_NHANVIENService : BaseService<NS_NHANVIEN, INS_NHANVIENRepository>
    , INS_NHANVIENService
    {
        private readonly INS_NHANVIENRepository _NS_NHANVIENRepository;
        public NS_NHANVIENService(INS_NHANVIENRepository NS_NHANVIENRepository) : base(NS_NHANVIENRepository)
        {
            _NS_NHANVIENRepository = NS_NHANVIENRepository;
        }
        public virtual async Task<NS_NHANVIEN> GetByNhanVien_IdAsync(int NhanVien_Id)
        {
            NS_NHANVIEN result = new NS_NHANVIEN();
            result = await GetByCondition(item => item.NhanVien_Id == NhanVien_Id).FirstOrDefaultAsync();
            if (result == null)
            {
                result = new NS_NHANVIEN();
            }
            return result;
        }
        public virtual async Task<NS_NHANVIEN> GetByMaNhanVienAsync(string MaNhanVien)
        {
            NS_NHANVIEN result = new NS_NHANVIEN();
            if (!string.IsNullOrEmpty(MaNhanVien))
            {
                result = await GetByCondition(item => item.MaNhanVien == MaNhanVien).FirstOrDefaultAsync();
            }
            if (result == null)
            {
                result = new NS_NHANVIEN();
            }
            return result;
        }
        public override async Task<List<NS_NHANVIEN>> GetAllToListAsync()
        {
            List<NS_NHANVIEN> result = new List<NS_NHANVIEN>();
            result = await GetByCondition(item => 1 == 1).OrderBy(item => item.Ten).ToListAsync();
            return result;
        }
    }
}

