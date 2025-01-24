namespace Service_eHospital_DongNai_A_System.Implement
{
    public class Sys_UserCommandsService : BaseService<Sys_UserCommands, ISys_UserCommandsRepository>
    , ISys_UserCommandsService
    {
        private readonly ISys_UserCommandsRepository _Sys_UserCommandsRepository;

        private readonly ISys_MenusRepository _Sys_MenusRepository;
        private readonly ISys_FunctionsRepository _Sys_FunctionsRepository;
        private readonly ISys_CommandsRepository _Sys_CommandsRepository;
        public Sys_UserCommandsService(ISys_UserCommandsRepository Sys_UserCommandsRepository
            , ISys_MenusRepository sys_MenusRepository
            , ISys_FunctionsRepository sys_FunctionsRepository
            , ISys_CommandsRepository sys_CommandsRepository



        ) : base(Sys_UserCommandsRepository)
        {
            _Sys_UserCommandsRepository = Sys_UserCommandsRepository;
            _Sys_MenusRepository = sys_MenusRepository;
            _Sys_FunctionsRepository = sys_FunctionsRepository;
            _Sys_CommandsRepository = sys_CommandsRepository;
        }
        public virtual async Task<List<Sys_UserCommands>> GetByUser_Id_SearchStringToListAsync(int User_Id, string searchString)
        {
            List<Sys_UserCommands> result = new List<Sys_UserCommands>();
            if (User_Id > 0)
            {
                result = await GetByCondition(item => item.User_Id == User_Id).ToListAsync();
                if (!string.IsNullOrEmpty(searchString))
                {
                    List<Sys_Menus> ListSys_Menus = await _Sys_MenusRepository.GetByCondition(item => item.Menu_Name.Contains(searchString) || item.Menu_Code.Contains(searchString)).ToListAsync();
                    if (ListSys_Menus == null)
                    {
                        ListSys_Menus = new List<Sys_Menus>();
                    }
                    List<int> ListSys_MenusID = ListSys_Menus.Select(item => item.Menu_Id.Value).ToList();
                    if (ListSys_MenusID.Count > 0)
                    {
                        result = result.Where(item => ListSys_MenusID.Contains(item.Menu_Id.Value)).ToList();
                    }

                    List<Sys_Functions> ListSys_Functions = await _Sys_FunctionsRepository.GetByCondition(item => item.Function_Name.Contains(searchString) || item.Function_Class.Contains(searchString)).ToListAsync();
                    if (ListSys_Functions == null)
                    {
                        ListSys_Functions = new List<Sys_Functions>();
                    }
                    List<int> ListSys_FunctionsID = ListSys_Functions.Select(item => item.Function_Id.Value).ToList();
                    if (ListSys_FunctionsID.Count > 0)
                    {
                        result = result.Where(item => ListSys_FunctionsID.Contains(item.Function_Id.Value)).ToList();
                    }

                    List<Sys_Commands> ListSys_Commands = await _Sys_CommandsRepository.GetByCondition(item => item.Command_Name.Contains(searchString) || item.Command_Text.Contains(searchString)).ToListAsync();
                    if (ListSys_Commands == null)
                    {
                        ListSys_Commands = new List<Sys_Commands>();
                    }
                    List<int> ListSys_CommandsID = ListSys_Commands.Select(item => item.Command_Id.Value).ToList();
                    if (ListSys_CommandsID.Count > 0)
                    {
                        result = result.Where(item => ListSys_CommandsID.Contains(item.Command_Id.Value)).ToList();
                    }
                }
                else
                {
                    result = await GetByCondition(item => item.User_Id == User_Id).ToListAsync();
                }
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
        public virtual async Task<List<Sys_UserCommands>> GetByUser_Id_SearchStringAndEmptyToListAsync(int User_Id, string searchString)
        {
            List<Sys_UserCommands> result = new List<Sys_UserCommands>();
            Sys_UserCommands empty = new Sys_UserCommands();
            result.Add(empty);
            List<Sys_UserCommands> list = await GetByUser_Id_SearchStringToListAsync(User_Id, searchString);
            if (list.Count > 0)
            {
                result.AddRange(list);
            }
            return result;
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

