using MyCoreAPIDemo.Entities;
using MyCoreAPIDemo.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPIDemo.Repository.Implementation
{
    public class LibraryRepository: ILibraryRepository<Author>
    {
        readonly LibraryContext _libraryContext;

        public LibraryRepository(LibraryContext context)
        {
            _libraryContext = context;
        }

        public IEnumerable<Author> GetAllAuthor()
        {
            return _libraryContext.Authors.ToList();
        }

        public Author GetAuthor(Guid authorId)
        {
            try
            {
                return _libraryContext.Authors.Where(e => e.AuthorId == authorId).FirstOrDefault();
            }
            catch(Exception ex)
            {
                //log exception
                return null;
            }
        }
        public Author PostAuthor(Author author)
        {
            try
            {
                if(_libraryContext!=null)
                {
                    _libraryContext.Add(author);
                    _libraryContext.SaveChanges();
                    return author;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                //log exception
                return null;
            }
        }

        public Author UpdateAuthor(Author author)
        {
            try
            {
                if (_libraryContext != null)
                {
                    _libraryContext.Update(author);
                    _libraryContext.SaveChanges();
                    return author;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                //log exception
                return null;
            }
        }

        public int DeleteAuthor(Guid authorId)
        {
            try
            {
                if (_libraryContext != null)
                {
                    var author = _libraryContext.Authors.FirstOrDefault(x => x.AuthorId== authorId);
                    if(author!=null)
                    {
                        _libraryContext.Remove(author);
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }


            }
            catch(Exception ex)
            {
                //log exception
                return 0;
            }
        }
    }
}
