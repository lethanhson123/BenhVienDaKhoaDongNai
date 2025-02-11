namespace Service_eHospital_DongNai_A_Dictionary.Implement
{
    public class NhanVien_User_MappingService : BaseService<NhanVien_User_Mapping, INhanVien_User_MappingRepository>
    , INhanVien_User_MappingService
    {
        private readonly INhanVien_User_MappingRepository _NhanVien_User_MappingRepository;
        public NhanVien_User_MappingService(INhanVien_User_MappingRepository NhanVien_User_MappingRepository) : base(NhanVien_User_MappingRepository)
        {
            _NhanVien_User_MappingRepository = NhanVien_User_MappingRepository;
        }
        public virtual async Task<List<NhanVien_User_Mapping>> GetByNhanVien_IdToListAsync(int NhanVien_Id)
        {
            List<NhanVien_User_Mapping> result = new List<NhanVien_User_Mapping>();
            result = await GetByCondition(item => item.NhanVien_Id == NhanVien_Id).ToListAsync();
            if (result == null)
            {
                result = new List<NhanVien_User_Mapping>();
            }
            return result;
        }
        public virtual async Task<List<NhanVien_User_Mapping>> GetByNhanVien_IdAndEmptyToListAsync(int NhanVien_Id)
        {
            List<NhanVien_User_Mapping> result = new List<NhanVien_User_Mapping>();
            NhanVien_User_Mapping empty = new NhanVien_User_Mapping();
            result.Add(empty);
            List<NhanVien_User_Mapping> list = await GetByNhanVien_IdToListAsync(NhanVien_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
        public virtual async Task<List<NhanVien_User_Mapping>> GetByUser_IdToListAsync(int User_Id)
        {
            List<NhanVien_User_Mapping> result = new List<NhanVien_User_Mapping>();
            result = await GetByCondition(item => item.User_Id == User_Id).ToListAsync();
            if (result == null)
            {
                result = new List<NhanVien_User_Mapping>();
            }
            return result;
        }
        public virtual async Task<List<NhanVien_User_Mapping>> GetByUser_IdAndEmptyToListAsync(int User_Id)
        {
            List<NhanVien_User_Mapping> result = new List<NhanVien_User_Mapping>();
            NhanVien_User_Mapping empty = new NhanVien_User_Mapping();
            result.Add(empty);
            List<NhanVien_User_Mapping> list = await GetByUser_IdToListAsync(User_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

