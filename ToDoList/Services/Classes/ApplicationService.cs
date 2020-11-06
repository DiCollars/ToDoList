using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using ToDoList.Models;
using ToDoList.Models.Data_base;
using ToDoList.Services.Interfaces;

namespace ToDoList.Services.Classes
{
    public class ApplicationService : IApplicationService
    {
        private ApplicationContext _context;
        private ViewModel _viewModel;
        public string MainTheme;

        public ApplicationService(ApplicationContext context)
        {
            _viewModel = new ViewModel();
            _context = context;
            MainTheme = GetTheme(0);
        }

        public ViewModel GetTasks(int? month, int? day)
        {
            if (day != default)
            {
                _viewModel.ListTasks = _context.TaskOfs.Where(t => t.Day.Date.Month == month && t.Day.Date.Day == day).OrderByDescending(t => t.Priority).ThenByDescending(t => t.Status).ToList();
                return _viewModel;
            }
            else
            {
                return _viewModel;
            }
        }

        public string GetMainTheme()
        {
            return MainTheme;
        }

        public void AddData(TaskOf taskOf)
        {
            if (taskOf.Summary != null)
            {
                taskOf.DayId = _context.Days.Include(t => t._Tasks)
                    .Where(d => d.Date == DateTime.Now.Date)
                    .First().Id;

                taskOf.SubPriority = taskOf.Priority;

                _context.TaskOfs.Add(taskOf);
                _context.SaveChanges();
            }
        }

        public ViewModel SwitchData(int? id, Priority? subPriority)
        {
            if (id != null && subPriority == Priority.Lower)
            {
                var taskForFix = _context.TaskOfs.First(t => t.Id == id);
                taskForFix.Priority = taskForFix.SubPriority;
                taskForFix.Status = false;
                _context.TaskOfs.Update(taskForFix);
                _context.SaveChanges();
            }

            if (id != null && subPriority != Priority.Lower)
            {
                var taskForFix = _context.TaskOfs.First(t => t.Id == id);
                taskForFix.Priority = Priority.Lower;
                taskForFix.Status = true;
                _context.TaskOfs.Update(taskForFix);
                _context.SaveChanges();
            }

            foreach (var task in _context.TaskOfs.ToList())
            {
                if (task.Status == true)
                {
                    var taskForFix = _context.TaskOfs.First(t => t.Id == task.Id);
                    taskForFix.Priority = Priority.Lower;
                    _context.TaskOfs.Update(taskForFix);
                    _context.SaveChanges();
                }
            }

            var today = _context.Days.Include(t => t._Tasks).Where(d => d.Date == DateTime.Now.Date).FirstOrDefault();
            _viewModel.ListTasks = today._Tasks.OrderByDescending(t => t.Priority).ThenByDescending(t => t.Status).ToList();
            
            return _viewModel;
        }

        public void SwitchTheme(int? theme)
        {
            if (theme != null)
            {
                GetTheme(theme);
            }
        }

        public string GetTheme(int? mode)
        {
            string path = @"Theme.txt";
            string line;

            if (mode == 100)
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("dark");
                }

                return line = "dark";
            }
            else if (mode == 101)
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("info");
                }

                return line = "info";
            }
            else if (mode == 102)
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("primary");
                }

                return line = "primary";
            }
            else if (mode == 104)
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("success");
                }

                return line = "success";
            }
            else if (mode == 105)
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("danger");
                }

                return line = "danger";
            }
            else if (mode == 106)
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("warning");
                }

                return line = "warning";
            }
            else
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    line = sr.ReadLine();
                }

                return line;
            }
        }

        public void DateCheck()
        {
            if (!_context.Months.Any(m => m.Number == DateTime.Now.Month))
            {
                foreach (var month in DateGenerator.allMonths)
                {
                    if (!_context.Months.Any(m => m.Name == month.Value))
                    {
                        _context.Months.Add(new Month()
                        {
                            Name = month.Value,
                            Number = month.Key
                        });

                        _context.SaveChanges();
                    }
                }
            }

            if (!_context.Months.Where(m => m.Number == DateTime.Now.Month).Include(m => m.Days).Any(m => m.Days.Any(d => d.Date == DateTime.Now)))
            {
                var currentDays = DateGenerator.GetDates(DateTime.Now.Year, DateTime.Now.Month);
                foreach (var day in currentDays)
                {
                    if (!_context.Days.Any(d => d.Date == day))
                    {
                        _context.Days.Add(new Day()
                        {
                            Date = day,
                            MonthId = _context.Months.Where(m => m.Number == DateTime.Now.Month).First().Id
                        });

                        _context.SaveChanges();
                    }
                }
            }
        }

        public ViewModel GetViewLists(int? id, int? year)
        {
            _viewModel.AllMonths = DateGenerator.allMonths;

            if (id != null)
            {
                if (year == null)
                {
                    year = DateTime.Now.Year;
                }

                var daysList = DateGenerator.GetDates(Convert.ToInt32(year), Convert.ToInt32(id)).ToArray();

                var CountDays = new (int, DateTime)[daysList.Length];

                for (int i = 0; i < daysList.Length; i++)
                {
                    if (_context.TaskOfs.Any(t => t.Day.Date == daysList[i].Date))
                    {
                        CountDays[i].Item1 = _context.TaskOfs.Where(t => t.Day.Date == daysList[i].Date).Count();
                        CountDays[i].Item2 = daysList[i];
                    }
                    else
                    {
                        CountDays[i].Item1 = 0;
                        CountDays[i].Item2 = daysList[i];
                    }
                }

                _viewModel.ListCountDays = CountDays;
            }

            return _viewModel;
        }
    }
}
