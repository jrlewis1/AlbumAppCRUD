using AlbumApp.Data;
using AlbumApp.Models.Domain;
using AlbumApp.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AlbumApp.Pages.Albums
{
    public class AddModel : PageModel
    {
        private readonly AlbumsDBContext dbContext;
        public AddModel(AlbumsDBContext dBContext) 
        { 
            this.dbContext = dBContext;
        }
        [BindProperty]
        public AddAlbumViewModel AddAlbumRequest { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            //COnvert ViewModel to DomainModel

            var albumDomainModel = new Album
            {
                Name = this.AddAlbumRequest.Name,
                Genre = this.AddAlbumRequest.Genre,
                Price = this.AddAlbumRequest.Price,
                ReleaseDate = this.AddAlbumRequest.ReleaseDate
            };

            dbContext.Albums.Add(albumDomainModel);
            dbContext.SaveChanges();
            ViewData["Message"] = "Employee Created Successfully";
            
        }
    }
}
