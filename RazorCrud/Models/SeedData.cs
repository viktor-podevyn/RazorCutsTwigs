using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorCrud.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorCrudSongsListContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudSongsListContext>>()))
            {
                // Look for any songs.
                if (!context.Songs.Any())
                {
                    context.Songs.AddRange(
                        new Songs
                        {
                            Title = "Leave The Door Open",
                            ReleaseDate = DateTime.Parse("2021-3-5"),
                            Genre = "soul",
                            Artist = "Bruno Mars & Anderson .Paak"
                        },

                        new Songs
                        {
                            Title = "Undercover",
                            ReleaseDate = DateTime.Parse("2020"),
                            Genre = "Electronic",
                            Artist = "Forester"
                        },

                        new Songs
                        {
                            Title = "MONTERO (Call Me By Your Name)",
                            ReleaseDate = DateTime.Parse("2021"),
                            Genre = "Pop/Hip-Hop",
                            Artist = "Lil nas X"
                        },

                        new Songs
                        {
                            Title = "No Man No Cry (Jimmy Sax Version)",
                            ReleaseDate = DateTime.Parse("2017"),
                            Genre = "Electronic/Sax",
                            Artist = "Oliver Koletzki"
                        }
                    );
                    context.SaveChanges();
                }
            }
            using (var context = new RazorCrudArtistsListContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudArtistsListContext>>()))
            {
                // Look for any songs.
                if (!context.Artists.Any())
                {
                    context.Artists.AddRange(
                        new Artists
                        {
                            Name = "Frank Ocean",
                            Genre = "Pop/R&B/Hip-Hop",
                            FamousSong = "Pink & White"
                        },

                        new Artists
                        {
                            Name = "Juice Wrld",
                            Genre = "Emo Rap",
                            FamousSong = "Lucid Dreams"
                        },

                        new Artists
                        {
                            Name = "Leave The Door Open",
                            Genre = "soul",
                            FamousSong = "Bruno Mars & Anderson .Paak"
                        },

                        new Artists
                        {
                            Name = "Leave The Door Open",
                            Genre = "soul",
                            FamousSong = "Bruno Mars & Anderson .Paak"
                        }
                    );
                    context.SaveChanges();
                }
            }
            using (var context = new RazorCrudAlbumsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorCrudAlbumsContext>>()))
            {
                // Look for any songs.
                if (!context.Albums.Any())
                {
                    context.Albums.AddRange(
                        new Albums
                        {
                            Name = "Leave The Door Open",
                            Genre = "soul",
                            Artist = "Bruno Mars & Anderson .Paak"
                        },

                        new Albums
                        {
                            Name = "Leave The Door Open",
                            Genre = "soul",
                            Artist = "Bruno Mars & Anderson .Paak"
                        },

                        new Albums
                        {
                            Name = "Leave The Door Open",
                            Genre = "soul",
                            Artist = "Bruno Mars & Anderson .Paak"
                        },

                        new Albums
                        {
                            Name = "Leave The Door Open",
                            Genre = "soul",
                            Artist = "Bruno Mars & Anderson .Paak"
                        }
                    );
                    context.SaveChanges();
                }
            }
        }



    }
}