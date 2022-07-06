using MovieDatabaseLab;

//list of all available movies
List<Movie> Movies = new List<Movie>
{
    new Movie("Jaws", "Thriller"),
    new Movie("The Shawshank Redemption", "Drama"),
    new Movie("Happy Gillmore", "Comedy"),
    new Movie("Jurassic World: Dominion", "Scifi"),
    new Movie("Forrest Gump", "Drama"),
    new Movie("Top Gun: Maverick", "Action"),
    new Movie("The Godfather", "Crime"),
    new Movie("Inception", "Action"),
    new Movie("The Matrix", "Scifi"),
    new Movie("Psycho", "Thriller")
};
bool runProgram = true;
//intro/getting movie choice from user
Console.WriteLine("Welcome to the lone surviving BlockBuster!");
while (runProgram)
{
    Console.WriteLine("we have \"Thriller\", \"Drama\", \"Scifi\", \"Comedy\", \"Crime\", and \"Action\" options available!");
    Console.WriteLine("What kind of movie were you looking for?");
    string choice = Console.ReadLine().ToLower().Trim();

    //linq statement adds any movie that matches user category to filteredmovie list
    List<Movie> filteredMovies = Movies.Where(x => x.Category.ToLower().Trim() == choice).ToList();
    foreach(Movie m in filteredMovies)
    {
        Console.WriteLine(m.Title);
    }
    if (filteredMovies.Count == 0)
    {
        Console.WriteLine("We couldn't find anything matching that genre...");
    }
    runProgram = GoAgain();
}
Console.WriteLine("Thanks for stopping by, enjoy your film.");

//methods
//Josh go again - thanks Josh
static bool GoAgain()
{
    while (true)
    {
        Console.WriteLine("Look for another category of movie? (y/n)?");
        string input = Console.ReadLine();
        try
        {
            if (input.ToLower().Trim() == "y")
            {
                return true;
            }
            else if (input.ToLower().Trim() == "n")
            {
                return false;
            }
            else
            {
                throw new Exception("Not a valid option, please try again.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
//use where method to automatically filter based on category