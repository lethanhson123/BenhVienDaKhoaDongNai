namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_UserCommandsService : BaseService<Sys_UserCommands, ISys_UserCommandsRepository>
    , ISys_UserCommandsService
    {
        private readonly ISys_UserCommandsRepository _Sys_UserCommandsRepository;
        public Sys_UserCommandsService(ISys_UserCommandsRepository Sys_UserCommandsRepository) : base(Sys_UserCommandsRepository)
        {
            _Sys_UserCommandsRepository = Sys_UserCommandsRepository;
        }
        public virtual async Task<List<Sys_UserCommands>> GetByUser_IdToListAsync(int User_Id)
        {
            List<Sys_UserCommands> result = new List<Sys_UserCommands>();
            if (User_Id > 0)
            {
                result = await GetByCondition(item => item.User_Id == User_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_UserCommands>();
            }
            return result;
        }
        public virtual async Task<List<Sys_UserCommands>> GetByUser_IdAndEmptyToListAsync(int User_Id)
        {
            List<Sys_UserCommands> result = new List<Sys_UserCommands>();
            Sys_UserCommands empty = new Sys_UserCommands();
            result.Add(empty);
            List<Sys_UserCommands> list = await GetByUser_IdToListAsync(User_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

