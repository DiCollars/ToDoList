using ToDoList.Models;

namespace ToDoList.Services.Interfaces
{
    public interface IApplicationService
    {
        void AddData(TaskOf taskOf);

        string GetTheme(int? mode);

        void DateCheck();

        ViewModel SwitchData(int? id, Priority? subPriority);

        string GetMainTheme();

        void SwitchTheme(int? theme);

        ViewModel GetViewLists(int? id, int? year);

        ViewModel GetTasks(int? month, int? day);
    }
}
