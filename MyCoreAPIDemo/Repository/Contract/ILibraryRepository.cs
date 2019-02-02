using MyCoreAPIDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPIDemo.Repository.Contract
{
    public interface ILibraryRepository<T>
    {
        IEnumerable<T> GetAllAuthor();

    }
}
