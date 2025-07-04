    using System;
    using System.Collections.Generic;
    using Todo.Models;


    namespace Todo.DAL
    {
        public interface ITodoReposetory : IDisposable
        {
            IEnumerable<TodoItem> GetStudents();
            TodoItem GetStudentByID(int TodoID);
            void InsertStudent(TodoItem Todos );
            void DeleteStudent(int TodoID);
            void UpdateStudent(TodoItem Todos);
            void Save();
        }
    }

