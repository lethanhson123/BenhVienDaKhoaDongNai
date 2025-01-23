namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_GroupCommandsService : BaseService<Sys_GroupCommands, ISys_GroupCommandsRepository>
    , ISys_GroupCommandsService
    {
        private readonly ISys_GroupCommandsRepository _Sys_GroupCommandsRepository;
        public Sys_GroupCommandsService(ISys_GroupCommandsRepository Sys_GroupCommandsRepository) : base(Sys_GroupCommandsRepository)
        {
            _Sys_GroupCommandsRepository = Sys_GroupCommandsRepository;
        }
        public virtual async Task<List<Sys_GroupCommands>> GetByGroup_IdToListAsync(int Group_Id)
        {
            List<Sys_GroupCommands> result = new List<Sys_GroupCommands>();
            if (Group_Id > 0)
            {
                result = await GetByCondition(item => item.Group_Id == Group_Id).ToListAsync();
            }
            else
            {
                result = await GetAllToListAsync();
            }
            if (result == null)
            {
                result = new List<Sys_GroupCommands>();
            }
            return result;
        }
        public virtual async Task<List<Sys_GroupCommands>> GetByGroup_IdAndEmptyToListAsync(int Group_Id)
        {
            List<Sys_GroupCommands> result = new List<Sys_GroupCommands>();
            Sys_GroupCommands empty = new Sys_GroupCommands();
            result.Add(empty);
            List<Sys_GroupCommands> list = await GetByGroup_IdToListAsync(Group_Id);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
        }
    }
}

