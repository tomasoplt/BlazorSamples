using BlazorServerSide.Shared.Models;
using System.Threading.Tasks;

namespace BlazorServerSide.Shared
{
    public interface IBooksClient
    {
        Task<PagedResult<Book>> ListBooks(int page);
        Task<Book> GetBook(int id);
        Task SaveBook(Book book);
        Task DeleteBook(Book book);
        Task DeleteBook(int id);
    }
}
