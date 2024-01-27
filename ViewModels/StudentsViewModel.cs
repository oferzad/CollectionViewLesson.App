using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CollectionViewLesson.Models;
using CollectionViewLesson.Services;

namespace CollectionViewLesson.ViewModels
{
    public class StudentsViewModel:ViewModelBase
    {
        private ObservableCollection<Student> students;
        public ObservableCollection<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
                OnPropertyChanged();
            }
        }
        public StudentsViewModel()
        {
            students = new ObservableCollection<Student>();
            SelectedNames = "none";
            SelectedStudents = new ObservableCollection<Object>();
            IsRefreshing = false;
            ReadStudents();
        }

        private async void ReadStudents()
        {
            StudentsService service = new StudentsService();
            List<Student> list = await service.GetStudents();
            this.Students = new ObservableCollection<Student>(list);
        }

        public ICommand DeleteCommand => new Command<Student>(RemoveStudent);

        void RemoveStudent(Student st)
        {
            if (Students.Contains(st))
            {
                Students.Remove(st);
            }
        }

        #region Multiple Selection
        private ObservableCollection<Object> selectedStudents;
        public ObservableCollection<Object> SelectedStudents
        {
            get
            {
                return this.selectedStudents;
            }
            set
            {
                this.selectedStudents = value;
                OnPropertyChanged();
            }
        }

        public ICommand MultipleSelectCommand => new Command(OnMultipleSelectStudent);

        async void OnMultipleSelectStudent()
        {
            if (SelectedStudents.Count==0)
            {
                SelectedNames = "none";
            }
            else
            {
                string temp = ((Student)SelectedStudents[0]).FirstName;
                for(int i=1;i<SelectedStudents.Count;i++)
                {
                    temp += $", {((Student)SelectedStudents[i]).FirstName}";
                }
                SelectedNames = temp;
            }
        }

        private string selectedNames;
        public string SelectedNames
        {
            get
            {
                return this.selectedNames;
            }
            set
            {
                this.selectedNames = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Single Selection
        private Object selectedStudent;
        public Object SelectedStudent
        {
            get
            {
                return this.selectedStudent;
            }
            set
            {
                this.selectedStudent = value;
                OnPropertyChanged();
            }
        }

        public ICommand SingleSelectCommand => new Command(OnSingleSelectStudent);

        async void OnSingleSelectStudent()
        {
            if (SelectedStudent == null || !(SelectedStudent is Student))
            {
                SelectedNames = "none";
            }
            else
                SelectedNames = ((Student)SelectedStudent).FirstName;
        }


        #endregion

        #region Refresh View
        public ICommand RefreshCommand => new Command(Refresh);
        private async void Refresh()
        {
            Students.Add(new Student
            {
                FirstName = "Just",
                LastName = "Added!",
                BirthDate = DateTime.Now,
                AverageScore = 100
            });
            

            IsRefreshing = false;
        }

        private bool isRefreshing;
        public bool IsRefreshing
        {
            get
            {
                return this.isRefreshing;
            }
            set
            {
                this.isRefreshing = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
