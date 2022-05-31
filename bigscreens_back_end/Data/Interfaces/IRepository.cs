using bigscreens_back_end.Models;

namespace bigscreens_back_end.Data
{
    public interface IRepository
    {
        List<Show> GetAllShows();
        Show GetShowById(int id);
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        void CreateMovie(Movie movie);
        void CreateShow(Show show);
        Movie UpdateMovie(int id, Movie movie);
        Show UpdateShow (int id, Show show);



    }
}
