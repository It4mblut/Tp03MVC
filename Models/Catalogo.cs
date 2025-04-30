namespace tp03.Models;

public static class Catalogo
{
    

    public static Dictionary<int, DatosDiscos> dicDiscos {get; private set;}

    public static void inicializarCatalogo(){

        dicDiscos=new Dictionary<int, DatosDiscos>();
        

       dicDiscos.Add(1, new DatosDiscos(
            "Future Nostalgia",
            "Dua Lipa",
            "Stephen Kozmeniuk",
            "Pop",
            "images/futureNostalgia.jfif",
            new List<string> { "Don't Start Now", "Physical", "Break My Heart", "Levitating" }
        ));

            dicDiscos.Add(2, new DatosDiscos(
                "Back In Black",
                "AC/DC",
                "Mutt Lange",
                "Rock",
                "images/backInBlack.png",
                new List<string> { "Hells Bells", "Shoot to Thrill", "Back In Black", "You Shook Me All Night Long" }
            ));

            dicDiscos.Add(3, new DatosDiscos(
                "Kind of Blue",
                "Miles Davis",
                "Miles Davis",
                "Jazz",
                "images/kindOfBlue.jfif",
                new List<string> { "So What", "Freddie Freeloader", "Blue in Green", "All Blues", "Flamenco Sketches" }
            ));

            dicDiscos.Add(4, new DatosDiscos(
                "Shape of You",
                "Ed Sheeran",
                "Steve Mac",
                "Pop",
                "images/shapeOfYou.jfif",
                new List<string> { "Shape of You" }
            ));

            dicDiscos.Add(5, new DatosDiscos(
                "Lemonade",
                "Beyoncé",
                "The-Dream",
                "R&B",
                "images/lemonade.jfif",
                new List<string> { "Pray You Catch Me", "Hold Up", "Sorry", "6 Inch", "Formation" }
            ));

            dicDiscos.Add(6, new DatosDiscos(
                "The Dark Side of the Moon",
                "Pink Floyd",
                "Pink Floyd",
                "Rock",
                "images/darkSideOfMoon.webp",
                new List<string> { "Speak to Me", "Breathe", "Time", "Money" }
            ));

            dicDiscos.Add(7, new DatosDiscos(
                "A Night at the Opera",
                "Queen",
                "Roy Thomas Baker",
                "Rock",
                "images/nightAtOpera.jfif",
                new List<string> { "Bohemian Rhapsody", "Love of My Life", "You're My Best Friend" }
            ));

            dicDiscos.Add(8, new DatosDiscos(
                "Thriller",
                "Michael Jackson",
                "Quincy Jones",
                "Pop",
                "images/thriller.webp",
                new List<string> { "Thriller", "Billie Jean", "Beat It", "Wanna Be Startin' Somethin'" }
            ));

            dicDiscos.Add(9, new DatosDiscos(
                "X&Y",
                "Coldplay",
                "Guy Berryman",
                "Rock Alternativo",
                "images/x&y.webp",
                new List<string> { "Speed of Sound", "Fix You", "Talk" }
            ));

            dicDiscos.Add(10, new DatosDiscos(
                "1989",
                "Taylor Swift",
                "Jack Antonoff",
                "Country",
                "images/1989.jpg",
                new List<string> { "Shake It Off", "Blank Space", "Style", "Bad Blood", "Wildest Dreams" }
            ));


    }





}