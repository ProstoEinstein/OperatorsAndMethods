using System;

namespace OperatorsAndMethods
{
    /// <summary>
    /// Description of the essence of the student. To check the average grade and student rating for the group.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student surname.
        /// </summary>
        public string Surname { get; private set; }

        /// <summary>
        /// Student name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Student middle name.
        /// </summary>
        public string MiddleName { get; private set; }

        /// <summary>
        /// Average rating for subjects.
        /// </summary>
        public double AverageMark { get; private set; }

        /// <summary>
        /// Group number.
        /// </summary>
        public int GroupNumber { get; private set; }

        /// <summary>
        /// Student rating by group.
        /// </summary>
        public int GroupRating { get; private set; }

        /// <summary>
        /// Entity initialization.
        /// </summary>
        /// <param name="surname">Student surname.</param>
        /// <param name="name">Student name.</param>
        /// <param name="middleName">Student middle name.</param>
        /// <param name="groupNumber">Group number.</param>
        public Student(string surname, string name, string middleName, int groupNumber)
        {
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            MiddleName = middleName ?? throw new ArgumentNullException(nameof(middleName));
            GroupNumber = groupNumber;
        }

        /// <summary>
        /// Student rating increment by group.
        /// </summary>
        /// <param name="student">Student essence.</param>
        /// <returns>Top rated studentр.</returns>
        public static Student operator ++(Student student)
        {
            student.GroupRating += 1;
            return student;
        }

        /// <summary>
        /// Student rating decrement by group.
        /// </summary>
        /// <param name="student">Student essence.</param>
        /// <returns>Downgraded student.</returns>
        public static Student operator --(Student student)
        {
            if (student.GroupRating <= 0)
            {
                return student;
            }
            student.GroupRating -= 1;
            return student;
        }

        /// <summary>
        /// Comparison of average scores for students.
        /// </summary>
        /// <param name="student1">The essence of the first student.</param>
        /// <param name="student2">The essence of the second student.</param>
        /// <returns>If students' average scores are equal returns <see langword="true"/>.</returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return student1.AverageMark == student2.AverageMark;
        }

        /// <summary>
        /// Comparison of average scores for students.
        /// </summary>
        /// <param name="student1">The essence of the first student.</param>
        /// <param name="student2">The essence of the second student.</param>
        /// <returns>If students' average scores are not equal returns <see langword="false"/>.</returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return student1.AverageMark != student2.AverageMark;
        }

        /// <summary>
        /// Method override Equals
        /// </summary>
        /// <param name="obj">Input object.</param>
        /// <returns>If the transferred object is a student and all fields are equal, will return <see langword="true"/>.</returns>
        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   Surname == student.Surname &&
                   Name == student.Name &&
                   MiddleName == student.MiddleName &&
                   AverageMark == student.AverageMark &&
                   GroupNumber == student.GroupNumber &&
                   GroupRating == student.GroupRating;
        }

        public override string ToString()
        {
            string result = $"Фамилия: {this.Surname}\n" +
                            $"Имя: {this.Name}\n" +
                            $"Отчество: {this.MiddleName}\n" +
                            $"Средний балл: {this.AverageMark}\n" +
                            $"Номер группы: {this.GroupNumber}\n" +
                            $"Рейтинг по группе: {this.GroupRating}\n";
            return result;
        }

        /// <summary>
        /// The method was created for testing purposes, in reality, the average score will be calculated by the student.
        /// </summary>
        /// <param name="averageMark"></param>
        public void SetAverageMark(double averageMark)
        {
            if (averageMark <= 0)
            {
                throw new ArgumentException("The score cannot be less than or equal to zero.");
            }
            this.AverageMark = averageMark;
        }

        /// <summary>
        /// Average score indexer. Just let it be :)
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public double this[double mark]
        {
            get
            {
                if (mark < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.AverageMark;
            }
        }
    }
}
