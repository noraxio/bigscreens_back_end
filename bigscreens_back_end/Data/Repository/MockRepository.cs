using bigscreens_back_end.Models;

namespace bigscreens_back_end.Data
{
    public class MockRepository : IRepository
    {
        List<Show> Showings = new List<Show>()
        {
            new Show() {Id = 1, ShowTime = 20},
            new Show() {Id = 2, ShowTime = 21},
            new Show() {Id = 3, ShowTime = 22}
        };

        List<Movie> Movies = new List<Movie>()
        {
            new Movie() {Id = 1, Title = "terminator", Genres = "action,adventure,cool-story-bro" },
            new Movie() {Id = 2, Title = "terminator2", Genres = "action,drama" },
            new Movie() {Id = 3, Title = "terminator the return", Genres = "drama,adventure,love" }
        };



        public MockRepository()
        {

        }

        public List<Show> GetAllShows()
        {
            return Showings;
        }
        public Show GetShowById(int id)
        {
            return Showings.FirstOrDefault(x => x.Id == id);
        }
        // might need to put this in another place later
        public List<Movie> GetAllMovies()
        {
            return Movies;
        }
        public Movie GetMovieById(int id)
        {
            return Movies.FirstOrDefault(x => x.Id == id);
        }

        public void CreateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void CreateShowing(Show show)
        {
            throw new NotImplementedException();
        }

        public void CreateShow(Show show)
        {
            throw new NotImplementedException();
        }

        public Movie UpdateMovie(int id, Movie movie)
        {
            throw new NotImplementedException();
        }

        public Show UpdateShow(int id, Show show)
        {
            throw new NotImplementedException();
        }
    }
}
