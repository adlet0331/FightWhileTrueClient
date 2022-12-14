using System;
using NonDestroyObject.DataManage;

namespace NonDestroyObject
{
    /// <summary>
    /// 여러 데이터들을 관리하는 매니저
    /// </summary>
    public class DataManager : Singleton<DataManager>
    {
        public PlayerDataManager PlayerDataManager;
        public StaticDataManager StaticDataManager;
        public ItemManager ItemManager;

        private void Start()
        {
            PlayerDataManager = new PlayerDataManager();
            PlayerDataManager.Start();
        }
    }
}