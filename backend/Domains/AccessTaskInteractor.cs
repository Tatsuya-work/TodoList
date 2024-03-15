using TodoList.Usecases;

namespace TodoList.Domains
{
    /// <summary>
    /// プロジェクトファイル解析インタラクタ
    /// </summary>
    public class AccessTaskInteractor : IAccessTaskUsecase
    {
        private readonly IAccessTaskUsecase _accessTaskUsecase;

        public AccessTaskInteractor(IAccessTaskUsecase accessTaskUsecase)
        {
            _accessTaskUsecase = accessTaskUsecase;
        }

        /// <summary>
        /// プロジェクトファイル解析
        /// </summary>
        /// <param name="projectFile"></param>
        /// <returns>ファイル名のリストとセッションID</returns>
        public void AddTask(string newTask)
        {
            return;
        }

        public object GetTask(string category)
        {
            return;
        }

        public void DoneTask(int id)
        {
            return;
        }
    }
}
