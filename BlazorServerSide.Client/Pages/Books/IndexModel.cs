using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorServerSide.Client.Services;
using BlazorServerSide.Shared;
using BlazorServerSide.Shared.Models;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorServerSide.Client.Pages.Books
{
    public class IndexModel : BaseComponent
    {
        [Parameter]
        protected string Page { get; set; } = "1";

        protected int DeleteId { get; set; } = 0;
        protected PagedResult<Book> Books;

        protected override async Task OnParametersSetAsync()
        {
            Console.WriteLine("Current page: " + Page);
            await LoadBooks(int.Parse(Page));
        }

        private async Task LoadBooks(int page)
        {
            Books = await BooksClient.ListBooks(page);
        }

        protected void PagerPageChanged(int page)
        {
            UriHelper.NavigateTo("/books/page/" + page);
        }

        protected void AddNew()
        {
            UriHelper.NavigateTo("/books/edit/0");
        }

        protected void EditBook(int id)
        {
            UriHelper.NavigateTo("/books/edit/" + id);
        }

        protected void ConfirmDelete(int id, string title)
        {
            DeleteId = id;
            RegisteredFunction.Invoke<bool>("confirmDelete", title);
        }

        protected async Task DeleteBook()
        {
            RegisteredFunction.Invoke<bool>("hideDeleteDialog");

            await BooksClient.DeleteBook(DeleteId);
            await LoadBooks(int.Parse(Page));
        }
    }
}