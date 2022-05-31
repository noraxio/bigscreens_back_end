using bigscreens_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace bigscreens_back_end.Data
{
    public class BigScreenRepository : IRepository
    {
        private readonly BigScreenDbContext _dbContext;

        public BigScreenRepository()
        {
            _dbContext = new BigScreenDbContext(); 
        }

        public void CreateMovie(Movie movie)
        {
            using(var db = _dbContext)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
        }

        public void CreateShow(Show show)
        {
            using( var db = _dbContext)
            {
                db.Shows.Add(show);
                db.SaveChanges();
            }
        }

        public List<Movie> GetAllMovies()
        {
            using (var db = _dbContext)
            {
                return db.Movies.ToList();
            }
        }

        public List<Show> GetAllShows()
        {
            using (var db = _dbContext)
            {
                return db.Shows.ToList();
            }
        }
        // vantar ad skoda show
        public Movie GetMovieById(int id)
        {
            using (var db = _dbContext)
            {
                return db.Movies.Include(s => s.Shows).FirstOrDefault(x => x.Id == id);
            }
        }

        public Show GetShowById(int id)
        {
            using (var db = _dbContext)
            {
                return db.Shows.FirstOrDefault(x => x.Id == id);
            }
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            Movie movieToUpdate;
            using (var db = _dbContext)
            {
                movieToUpdate = db.Movies.FirstOrDefault(x => x.Id == id);
                if (movieToUpdate == null)
                {
                    return null;
                }

                movieToUpdate.Title = movie.Title;
                movieToUpdate.RunTime = movie.RunTime;
                movieToUpdate.Rating = movie.Rating;
                movieToUpdate.PlotSummery = movie.PlotSummery;
                movieToUpdate.PgLevel = movie.PgLevel;
                movieToUpdate.Genres = movie.Genres;

                db.SaveChanges();

                return movieToUpdate;

            }
        }

        public Show UpdateShow(int id, Show show)
        {
            throw new NotImplementedException();
        }
    }
}
