// See https://aka.ms/new-console-template for more information
using Facade_Pattern;
using Facade_Pattern.SubSystem;

Console.WriteLine("Hello, World!");
Movie myMovie = new Movie { name = "the wire" };
HomeTheaterFacade homeTheater = new HomeTheaterFacade(new Player(), new Radio(), new Screen());
homeTheater.playMovie(myMovie);
homeTheater.endMovie();