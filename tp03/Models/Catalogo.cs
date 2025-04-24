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
            new List<string> { "Don't Start Now", "Physical", "Break My Heart", "Levitating" }
        ));

            // Caso 2: Disco de AC/DC, productor Mutt Lange, género Rock, 4 temas
        dicDiscos.Add(2, new DatosDiscos(
            "Back In Black",
            "AC/DC",
            "Mutt Lange",
            "Rock",
            new List<string> { "Hells Bells", "Shoot to Thrill", "Back In Black", "You Shook Me All Night Long" }
        ));

            // Caso 3: Disco de Miles Davis, productor Miles Davis, género Jazz, 5 temas
        dicDiscos.Add(3, new DatosDiscos(
            "Kind of Blue",
            "Miles Davis",
            "Miles Davis",
            "Jazz",
            new List<string> { "So What", "Freddie Freeloader", "Blue in Green", "All Blues", "Flamenco Sketches" }
        ));

            // Caso 4: Disco de Ed Sheeran, productor Steve Mac, género Pop, 1 tema
        dicDiscos.Add(4, new DatosDiscos(
            "Shape of You",
            "Ed Sheeran",
            "Steve Mac",
            "Pop",
            new List<string> { "Shape of You" }
        ));

            // Caso 5: Disco de Beyoncé, productor The-Dream, género R&B, 5 temas
        dicDiscos.Add(5, new DatosDiscos(
            "Lemonade",
            "Beyoncé",
            "The-Dream",
            "R&B",
            new List<string> { "Pray You Catch Me", "Hold Up", "Sorry", "6 Inch", "Formation" }
        ));

            // Caso 6: Disco de Pink Floyd, productor, género Rock, 4 temas
        dicDiscos.Add(6, new DatosDiscos(
            "The Dark Side of the Moon",
            "Pink Floyd",
            "Pink Floyd",
            "Rock",
            new List<string> { "Speak to Me", "Breathe", "Time", "Money" }
        ));

            // Caso 7: Disco de Queen, productor Roy Thomas Baker, género Rock, 3 temas
        dicDiscos.Add(7, new DatosDiscos(
            "A Night at the Opera",
            "Queen",
            "Roy Thomas Baker",
            "Rock",
            new List<string> { "Bohemian Rhapsody", "Love of My Life", "You're My Best Friend" }
        ));

            // Caso 8: Disco de Michael Jackson, productor Quincy Jones, género Pop, 4 temas
        dicDiscos.Add(8, new DatosDiscos(
            "Thriller",
            "Michael Jackson",
            "Quincy Jones",
            "Pop",
            new List<string> { "Thriller", "Billie Jean", "Beat It", "Wanna Be Startin' Somethin'" }
        ));

            // Caso 9: Disco de Coldplay, productor Guy Berryman, género Rock Alternativo, 3 temas
        dicDiscos.Add(9, new DatosDiscos(
            "X&Y",
            "Coldplay",
            "Guy Berryman",
            "Rock Alternativo",
            new List<string> { "Speed of Sound", "Fix You", "Talk" }
        ));

            // Caso 10: Disco de Taylor Swift, productor Jack Antonoff, género Country, 5 temas
        dicDiscos.Add(10, new DatosDiscos(
            "1989",
            "Taylor Swift",
            "Jack Antonoff",
            "Country",
            new List<string> { "Shake It Off", "Blank Space", "Style", "Bad Blood", "Wildest Dreams" }
        ));






    }





}