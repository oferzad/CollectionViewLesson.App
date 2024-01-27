using CollectionViewLesson.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollectionViewLesson.Services
{
    public class StudentsService
    {
            private List<Student> students;
            public StudentsService()
            {
                students = new List<Student>();

                InitStudents();
            }
            private void InitStudents()
            {
                this.students.Add(new Student
                {
                    FirstName = "Ofer",
                    LastName = "Zadikario",
                    BirthDate = new DateTime(1972, 11, 15),
                    AverageScore = 90
                });

                this.students.Add(new Student
                {
                    FirstName = "Tal",
                    LastName = "Simon",
                    BirthDate = new DateTime(1975, 1, 11),
                    AverageScore = 90
                });

                this.students.Add(new Student
                {
                    FirstName = "Racheli",
                    LastName = "Zosiman",
                    BirthDate = new DateTime(1980, 1, 11),
                    AverageScore = 90
                });

                this.students.Add(new Student
                {
                    FirstName = "Smadar",
                    LastName = "Vechter",
                    BirthDate = new DateTime(1965, 1, 11),
                    AverageScore = 90
                });

                this.students.Add(new Student
                {
                    FirstName = "Adi",
                    LastName = "Menahem",
                    BirthDate = new DateTime(1980, 1, 11),
                    AverageScore = 90
                });

            }

            public async Task<List<Student>> GetStudents()
            {
                return students;
            }

        }
    }

