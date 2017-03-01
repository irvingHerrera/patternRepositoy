using SchoolRepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRepository.Repository.Repositories
{
    public class UnityOfWork : IDisposable
    {
        private SchoolModelContainer context;
        public Repository<Student> Student { get; private set; }

        public UnityOfWork()
        {
            context = new SchoolModelContainer();
            Student = new Repository<Student>(context);
        }

        public int Save()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
