using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        IQueryable<Book> GetAllBooks(bool trackChanges);

        Book GetOneBooksById(int id, bool trackChanges);

        void CreatOneBook(Book book);
        void UpdteOneBook(Book book);
        void DeleteOneBook(Book book);

    }
}
