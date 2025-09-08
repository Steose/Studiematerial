# Samlingar för Verkliga Problem 📊

Nu tar vi datastrukturer till nästa nivå! Från enkla listor till komplexa system som hanterar stora mängder data. Här lär du dig använda Collections för att lösa riktiga problem! 🚀

## 🎯 Vad kommer du att bemästra?

- Lists för dynamiska samlingar
- Dictionaries för snabb uppslagning
- Arrays för prestandakritiska operationer
- LINQ för kraftfull datamanipulation
- Custom collections för specialiserade behov

---

## 🎵 Övning 1: Spotify Playlist Manager (Lists & LINQ)

**Problem:** Bygg ett system som hanterar Spotify-spelllistor med avancerade funktioner!

```csharp
// Song class för att representera låtar
public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }
    public TimeSpan Duration { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public int PlayCount { get; set; }
    public double Rating { get; set; } // 1-5 stjärnor
    public DateTime LastPlayed { get; set; }

    public Song(string title, string artist, string album, int minutes, int seconds,
                string genre, int year, double rating = 0)
    {
        Title = title;
        Artist = artist;
        Album = album;
        Duration = new TimeSpan(0, minutes, seconds);
        Genre = genre;
        ReleaseYear = year;
        Rating = rating;
        PlayCount = 0;
        LastPlayed = DateTime.MinValue;
    }

    public void Play()
    {
        PlayCount++;
        LastPlayed = DateTime.Now;
        Console.WriteLine($"🎵 Nu spelar: {Artist} - {Title}");
    }

    public override string ToString()
    {
        return $"{Artist} - {Title} ({Duration:mm\\:ss}) [{Genre}] ⭐{Rating:F1}";
    }
}

// Playlist manager system
public class PlaylistManager
{
    private Dictionary<string, List<Song>> playlists;
    private List<Song> allSongs;
    private Dictionary<string, int> genreStats;

    public PlaylistManager()
    {
        playlists = new Dictionary<string, List<Song>>();
        allSongs = new List<Song>();
        genreStats = new Dictionary<string, int>();
        InitializeWithSampleData();
    }

    private void InitializeWithSampleData()
    {
        // Lägg till sample songs
        var sampleSongs = new List<Song>
        {
            new Song("Bohemian Rhapsody", "Queen", "A Night at the Opera", 5, 55, "Rock", 1975, 4.8),
            new Song("Billie Jean", "Michael Jackson", "Thriller", 4, 54, "Pop", 1983, 4.7),
            new Song("Stairway to Heaven", "Led Zeppelin", "Led Zeppelin IV", 8, 2, "Rock", 1971, 4.9),
            new Song("Hey Jude", "The Beatles", "Hey Jude", 7, 11, "Rock", 1968, 4.6),
            new Song("Hotel California", "Eagles", "Hotel California", 6, 30, "Rock", 1976, 4.8),
            new Song("Imagine", "John Lennon", "Imagine", 3, 3, "Pop", 1971, 4.5),
            new Song("Smells Like Teen Spirit", "Nirvana", "Nevermind", 5, 1, "Grunge", 1991, 4.4),
            new Song("Sweet Child O' Mine", "Guns N' Roses", "Appetite for Destruction", 5, 56, "Rock", 1987, 4.7),
            new Song("Thunderstruck", "AC/DC", "The Razors Edge", 4, 52, "Rock", 1990, 4.6),
            new Song("Black", "Pearl Jam", "Ten", 5, 43, "Grunge", 1991, 4.3),
            new Song("Creep", "Radiohead", "Pablo Honey", 3, 58, "Alternative", 1992, 4.2),
            new Song("Zombie", "The Cranberries", "No Need to Argue", 5, 6, "Alternative", 1994, 4.1),
            new Song("Mr. Brightside", "The Killers", "Hot Fuss", 3, 42, "Indie", 2003, 4.4),
            new Song("Seven Nation Army", "The White Stripes", "Elephant", 3, 51, "Rock", 2003, 4.5),
            new Song("Everybody Hurts", "R.E.M.", "Automatic for the People", 5, 17, "Alternative", 1992, 4.2)
        };

        foreach (var song in sampleSongs)
        {
            AddSong(song);
        }

        // Skapa default playlists
        CreatePlaylist("Favorites");
        CreatePlaylist("Rock Classics");
        CreatePlaylist("Workout");
        CreatePlaylist("Chill");
    }

    public void AddSong(Song song)
    {
        allSongs.Add(song);

        // Uppdatera genre stats
        if (genreStats.ContainsKey(song.Genre))
        {
            genreStats[song.Genre]++;
        }
        else
        {
            genreStats[song.Genre] = 1;
        }

        Console.WriteLine($"✅ Lade till: {song}");
    }

    public void CreatePlaylist(string name)
    {
        if (!playlists.ContainsKey(name))
        {
            playlists[name] = new List<Song>();
            Console.WriteLine($"📝 Skapade playlist: {name}");
        }
        else
        {
            Console.WriteLine($"❌ Playlist '{name}' finns redan!");
        }
    }

    public void AddToPlaylist(string playlistName, Song song)
    {
        if (playlists.ContainsKey(playlistName))
        {
            if (!playlists[playlistName].Contains(song))
            {
                playlists[playlistName].Add(song);
                Console.WriteLine($"✅ Lade till '{song.Title}' i playlist '{playlistName}'");
            }
            else
            {
                Console.WriteLine($"❌ '{song.Title}' finns redan i '{playlistName}'!");
            }
        }
        else
        {
            Console.WriteLine($"❌ Playlist '{playlistName}' existerar inte!");
        }
    }

    // LINQ-powered search functions
    public List<Song> SearchByArtist(string artistName)
    {
        return allSongs.Where(song => song.Artist.ToLower()
                      .Contains(artistName.ToLower()))
                      .OrderBy(song => song.Title)
                      .ToList();
    }

    public List<Song> SearchByGenre(string genre)
    {
        return allSongs.Where(song => song.Genre.ToLower() == genre.ToLower())
                      .OrderByDescending(song => song.Rating)
                      .ToList();
    }

    public List<Song> GetTopRatedSongs(int count = 10)
    {
        return allSongs.OrderByDescending(song => song.Rating)
                      .ThenByDescending(song => song.PlayCount)
                      .Take(count)
                      .ToList();
    }

    public List<Song> GetSongsByDecade(int decade)
    {
        int startYear = decade;
        int endYear = decade + 9;

        return allSongs.Where(song => song.ReleaseYear >= startYear &&
                             song.ReleaseYear <= endYear)
                      .OrderBy(song => song.ReleaseYear)
                      .ThenBy(song => song.Artist)
                      .ToList();
    }

    public List<Song> GetRecentlyPlayed(int days = 7)
    {
        DateTime cutoffDate = DateTime.Now.AddDays(-days);

        return allSongs.Where(song => song.LastPlayed > cutoffDate)
                      .OrderByDescending(song => song.LastPlayed)
                      .ToList();
    }

    // Smart playlist generation
    public void CreateSmartPlaylist(string name, string criteria)
    {
        List<Song> smartSongs = new List<Song>();

        switch (criteria.ToLower())
        {
            case "workout":
                // Energiska låtar från rock/pop
                smartSongs = allSongs.Where(s => (s.Genre == "Rock" || s.Genre == "Pop") &&
                                           s.Rating >= 4.0)
                                    .OrderByDescending(s => s.Rating)
                                    .Take(15)
                                    .ToList();
                break;

            case "chill":
                // Lugna låtar med lägre tempo
                smartSongs = allSongs.Where(s => s.Genre == "Alternative" ||
                                           s.Duration.TotalMinutes > 4)
                                    .OrderBy(s => s.Title)
                                    .Take(12)
                                    .ToList();
                break;

            case "classics":
                // Gamla favoriterna
                smartSongs = allSongs.Where(s => s.ReleaseYear < 1990 && s.Rating >= 4.5)
                                    .OrderByDescending(s => s.Rating)
                                    .ToList();
                break;

            case "discover":
                // Låtar med låg play count för upptäckt
                smartSongs = allSongs.Where(s => s.PlayCount < 3)
                                    .OrderByDescending(s => s.Rating)
                                    .Take(10)
                                    .ToList();
                break;
        }

        if (smartSongs.Any())
        {
            playlists[name] = smartSongs;
            Console.WriteLine($"🤖 Smart playlist '{name}' skapad med {smartSongs.Count} låtar!");
        }
    }

    public void ShowPlaylistStats(string playlistName)
    {
        if (!playlists.ContainsKey(playlistName))
        {
            Console.WriteLine($"❌ Playlist '{playlistName}' existerar inte!");
            return;
        }

        var playlist = playlists[playlistName];

        if (!playlist.Any())
        {
            Console.WriteLine($"📝 Playlist '{playlistName}' är tom!");
            return;
        }

        Console.WriteLine($"\n📊 STATISTIK FÖR '{playlistName.ToUpper()}':");
        Console.WriteLine($"📈 Antal låtar: {playlist.Count}");

        var totalDuration = playlist.Aggregate(TimeSpan.Zero, (sum, song) => sum.Add(song.Duration));
        Console.WriteLine($"⏱️ Total längd: {totalDuration.Hours}h {totalDuration.Minutes}m {totalDuration.Seconds}s");

        var averageRating = playlist.Average(s => s.Rating);
        Console.WriteLine($"⭐ Genomsnittlig rating: {averageRating:F1}/5.0");

        var genreBreakdown = playlist.GroupBy(s => s.Genre)
                                   .Select(g => new { Genre = g.Key, Count = g.Count() })
                                   .OrderByDescending(x => x.Count);

        Console.WriteLine($"🎵 Genrer:");
        foreach (var genre in genreBreakdown)
        {
            Console.WriteLine($"  • {genre.Genre}: {genre.Count} låtar");
        }

        var oldestSong = playlist.OrderBy(s => s.ReleaseYear).First();
        var newestSong = playlist.OrderByDescending(s => s.ReleaseYear).First();
        Console.WriteLine($"🗓️ Äldsta: {oldestSong.Title} ({oldestSong.ReleaseYear})");
        Console.WriteLine($"🗓️ Nyaste: {newestSong.Title} ({newestSong.ReleaseYear})");

        Console.WriteLine();
    }

    public void ShowAllPlaylists()
    {
        Console.WriteLine("📝 ALLA SPELLISTOR:");
        foreach (var playlist in playlists)
        {
            var duration = playlist.Value.Aggregate(TimeSpan.Zero, (sum, song) => sum.Add(song.Duration));
            Console.WriteLine($"• {playlist.Key}: {playlist.Value.Count} låtar ({duration.Hours}h {duration.Minutes}m)");
        }
        Console.WriteLine();
    }

    public void PlayPlaylist(string playlistName, bool shuffle = false)
    {
        if (!playlists.ContainsKey(playlistName))
        {
            Console.WriteLine($"❌ Playlist '{playlistName}' existerar inte!");
            return;
        }

        var playlist = playlists[playlistName].ToList(); // Copy to avoid modifying original

        if (shuffle)
        {
            // Fisher-Yates shuffle
            Random rand = new Random();
            for (int i = playlist.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                (playlist[i], playlist[j]) = (playlist[j], playlist[i]);
            }
            Console.WriteLine($"🔀 Spelar '{playlistName}' i slumpmässig ordning:");
        }
        else
        {
            Console.WriteLine($"▶️ Spelar '{playlistName}':");
        }

        foreach (var song in playlist.Take(5)) // Play first 5 songs in demo
        {
            song.Play();
            System.Threading.Thread.Sleep(500); // Simulate playing
        }

        if (playlist.Count > 5)
        {
            Console.WriteLine($"... och {playlist.Count - 5} fler låtar");
        }
    }

    public void ShowMusicLibraryStats()
    {
        Console.WriteLine("\n📊 MUSIKBIBLIOTEK STATISTIK:");
        Console.WriteLine($"📈 Totalt antal låtar: {allSongs.Count}");

        var totalDuration = allSongs.Aggregate(TimeSpan.Zero, (sum, song) => sum.Add(song.Duration));
        Console.WriteLine($"⏱️ Total speltid: {totalDuration.TotalHours:F1} timmar");

        var totalPlays = allSongs.Sum(s => s.PlayCount);
        Console.WriteLine($"🎵 Totala uppspelningar: {totalPlays}");

        var averageRating = allSongs.Average(s => s.Rating);
        Console.WriteLine($"⭐ Genomsnittlig rating: {averageRating:F1}/5.0");

        Console.WriteLine($"\n🎵 GENRE FÖRDELNING:");
        var sortedGenres = genreStats.OrderByDescending(kvp => kvp.Value);
        foreach (var genre in sortedGenres)
        {
            double percentage = (double)genre.Value / allSongs.Count * 100;
            Console.WriteLine($"• {genre.Key}: {genre.Value} låtar ({percentage:F1}%)");
        }

        Console.WriteLine($"\n📅 ÅR FÖRDELNING:");
        var decadeStats = allSongs.GroupBy(s => (s.ReleaseYear / 10) * 10)
                                 .Select(g => new { Decade = g.Key, Count = g.Count() })
                                 .OrderBy(x => x.Decade);

        foreach (var decade in decadeStats)
        {
            Console.WriteLine($"• {decade.Decade}s: {decade.Count} låtar");
        }

        Console.WriteLine();
    }
}

// Demo program
class SpotifyDemo
{
    static void Main()
    {
        Console.WriteLine("🎵 WELCOME TO SPOTIFY PLAYLIST MANAGER 🎵\n");

        var manager = new PlaylistManager();

        // Lägg till låtar i playlists
        var rockSongs = manager.SearchByGenre("Rock");
        foreach (var song in rockSongs.Take(5))
        {
            manager.AddToPlaylist("Rock Classics", song);
        }

        var topSongs = manager.GetTopRatedSongs(3);
        foreach (var song in topSongs)
        {
            manager.AddToPlaylist("Favorites", song);
        }

        // Skapa smart playlists
        manager.CreateSmartPlaylist("Workout Mix", "workout");
        manager.CreateSmartPlaylist("Chill Vibes", "chill");
        manager.CreateSmartPlaylist("Golden Oldies", "classics");
        manager.CreateSmartPlaylist("Discovery Queue", "discover");

        // Visa alla playlists
        manager.ShowAllPlaylists();

        // Visa statistik för specifik playlist
        manager.ShowPlaylistStats("Rock Classics");
        manager.ShowPlaylistStats("Workout Mix");

        // Spela playlists
        manager.PlayPlaylist("Favorites");
        Console.WriteLine();
        manager.PlayPlaylist("Workout Mix", shuffle: true);

        // Visa library stats
        manager.ShowMusicLibraryStats();

        // Sök funktioner
        Console.WriteLine("🔍 SÖK RESULTAT:");
        var queenSongs = manager.SearchByArtist("Queen");
        Console.WriteLine($"Queen låtar: {queenSongs.Count}");
        queenSongs.ForEach(s => Console.WriteLine($"  • {s}"));

        var nineties = manager.GetSongsByDecade(1990);
        Console.WriteLine($"\n90-tals låtar: {nineties.Count}");
        nineties.Take(3).ToList().ForEach(s => Console.WriteLine($"  • {s}"));
    }
}
```

**Din uppgift:**
1. Lägg till "Recently Added" funktionalitet
2. Implementera playlist export/import från JSON
3. Skapa collaborative playlists med flera användare

---

## 🍕 Övning 2: Restaurant Order System (Dictionaries & Complex Objects)

**Problem:** Bygg ett restaurangbeställningssystem som hanterar menyer, beställningar och statistik!

```csharp
// Menu item class
public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Category { get; set; }
    public List<string> Ingredients { get; set; }
    public List<string> Allergens { get; set; }
    public bool IsAvailable { get; set; }
    public int PreparationTimeMinutes { get; set; }
    public int TimesOrdered { get; set; }

    public MenuItem(int id, string name, string description, double price,
                   string category, int prepTime)
    {
        Id = id;
        Name = name;
        Description = description;
        Price = price;
        Category = category;
        PreparationTimeMinutes = prepTime;
        Ingredients = new List<string>();
        Allergens = new List<string>();
        IsAvailable = true;
        TimesOrdered = 0;
    }

    public void AddIngredient(params string[] ingredients)
    {
        Ingredients.AddRange(ingredients);
    }

    public void AddAllergen(params string[] allergens)
    {
        Allergens.AddRange(allergens);
    }

    public override string ToString()
    {
        var availability = IsAvailable ? "✅" : "❌";
        var allergenStr = Allergens.Any() ? $" [Allergen: {string.Join(", ", Allergens)}]" : "";
        return $"{availability} {Name} - {Price:C} ({PreparationTimeMinutes}min){allergenStr}";
    }
}

// Order item class
public class OrderItem
{
    public MenuItem MenuItem { get; set; }
    public int Quantity { get; set; }
    public List<string> SpecialRequests { get; set; }
    public double ItemTotal => MenuItem.Price * Quantity;

    public OrderItem(MenuItem menuItem, int quantity = 1)
    {
        MenuItem = menuItem;
        Quantity = quantity;
        SpecialRequests = new List<string>();
    }

    public void AddSpecialRequest(string request)
    {
        SpecialRequests.Add(request);
    }

    public override string ToString()
    {
        var special = SpecialRequests.Any() ? $" ({string.Join(", ", SpecialRequests)})" : "";
        return $"{Quantity}x {MenuItem.Name}{special} - {ItemTotal:C}";
    }
}

// Customer order class
public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerPhone { get; set; }
    public DateTime OrderTime { get; set; }
    public List<OrderItem> Items { get; set; }
    public OrderStatus Status { get; set; }
    public double SubTotal => Items.Sum(item => item.ItemTotal);
    public double Tax => SubTotal * 0.25; // 25% moms
    public double Total => SubTotal + Tax;
    public int EstimatedPrepTime => Items.Max(i => i.MenuItem.PreparationTimeMinutes);

    public Order(int orderId, string customerName, string phone = "")
    {
        OrderId = orderId;
        CustomerName = customerName;
        CustomerPhone = phone;
        OrderTime = DateTime.Now;
        Items = new List<OrderItem>();
        Status = OrderStatus.Pending;
    }

    public void AddItem(MenuItem menuItem, int quantity = 1, params string[] specialRequests)
    {
        var existingItem = Items.FirstOrDefault(i => i.MenuItem.Id == menuItem.Id &&
                                               i.SpecialRequests.SequenceEqual(specialRequests));

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            var newItem = new OrderItem(menuItem, quantity);
            foreach (var request in specialRequests)
            {
                newItem.AddSpecialRequest(request);
            }
            Items.Add(newItem);
        }

        menuItem.TimesOrdered += quantity;
    }

    public bool RemoveItem(int menuItemId, int quantity = 1)
    {
        var item = Items.FirstOrDefault(i => i.MenuItem.Id == menuItemId);
        if (item != null)
        {
            item.Quantity -= quantity;
            item.MenuItem.TimesOrdered -= quantity;

            if (item.Quantity <= 0)
            {
                Items.Remove(item);
            }
            return true;
        }
        return false;
    }

    public void PrintReceipt()
    {
        Console.WriteLine("\n" + "".PadRight(40, '='));
        Console.WriteLine($"   MARCUS PIZZERIA - KVITTO #{OrderId}");
        Console.WriteLine("".PadRight(40, '='));
        Console.WriteLine($"Kund: {CustomerName}");
        Console.WriteLine($"Telefon: {CustomerPhone}");
        Console.WriteLine($"Tid: {OrderTime:yyyy-MM-dd HH:mm}");
        Console.WriteLine($"Status: {Status}");
        Console.WriteLine("".PadRight(40, '-'));

        foreach (var item in Items)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("".PadRight(40, '-'));
        Console.WriteLine($"Delsumma: {SubTotal:C}");
        Console.WriteLine($"Moms (25%): {Tax:C}");
        Console.WriteLine($"TOTALT: {Total:C}");
        Console.WriteLine($"Beräknad tillagningstid: {EstimatedPrepTime} min");
        Console.WriteLine("".PadRight(40, '='));
        Console.WriteLine("Tack för din beställning! 🍕");
        Console.WriteLine();
    }
}

public enum OrderStatus
{
    Pending,
    Confirmed,
    InPreparation,
    Ready,
    Delivered,
    Cancelled
}

// Restaurant management system
public class RestaurantManager
{
    private Dictionary<int, MenuItem> menu;
    private Dictionary<string, List<MenuItem>> menuByCategory;
    private Dictionary<int, Order> orders;
    private Dictionary<string, Customer> customers;
    private int nextOrderId;
    private int nextMenuItemId;

    public RestaurantManager()
    {
        menu = new Dictionary<int, MenuItem>();
        menuByCategory = new Dictionary<string, List<MenuItem>>();
        orders = new Dictionary<int, Order>();
        customers = new Dictionary<string, Customer>();
        nextOrderId = 1001;
        nextMenuItemId = 1;

        InitializeMenu();
    }

    private void InitializeMenu()
    {
        // Pizza-kategorin
        var margherita = new MenuItem(nextMenuItemId++, "Margherita",
            "Klassisk pizza med tomatås, mozzarella och basilika",
            89.0, "Pizza", 12);
        margherita.AddIngredient("Tomatås", "Mozzarella", "Basilika", "Olivolja");
        margherita.AddAllergen("Gluten", "Laktos");

        var hawaii = new MenuItem(nextMenuItemId++, "Hawaii",
            "Skinka, ananas och extra ost",
            109.0, "Pizza", 14);
        hawaii.AddIngredient("Tomatås", "Mozzarella", "Skinka", "Ananas");
        hawaii.AddAllergen("Gluten", "Laktos");

        var kebabPizza = new MenuItem(nextMenuItemId++, "Kebabpizza",
            "Kebabkött, lök, tomat, sallad och vitlökssås",
            125.0, "Pizza", 16);
        kebabPizza.AddIngredient("Tomatås", "Mozzarella", "Kebabkött", "Lök", "Tomat", "Sallad", "Vitlökssås");
        kebabPizza.AddAllergen("Gluten", "Laktos");

        var quattroStagioni = new MenuItem(nextMenuItemId++, "Quattro Stagioni",
            "Fyra årrstider - skinka, champinjoner, kronärtskocka, oliver",
            139.0, "Pizza", 18);
        quattroStagioni.AddIngredient("Tomatås", "Mozzarella", "Skinka", "Champinjoner", "Kronärtskocka", "Oliver");
        quattroStagioni.AddAllergen("Gluten", "Laktos");

        // Pasta-kategorin
        var spaghettiCarbonara = new MenuItem(nextMenuItemId++, "Spaghetti Carbonara",
            "Klassisk carbonara med äggula, parmesan och bacon",
            115.0, "Pasta", 15);
        spaghettiCarbonara.AddIngredient("Spaghetti", "Äggula", "Parmesan", "Bacon", "Svartpeppar");
        spaghettiCarbonara.AddAllergen("Gluten", "Ägg", "Laktos");

        var penneArrabbiata = new MenuItem(nextMenuItemId++, "Penne Arrabbiata",
            "Stark pasta med tomat, chili och vitlök",
            95.0, "Pasta", 12);
        penneArrabbiata.AddIngredient("Penne", "Tomatås", "Chili", "Vitlök", "Olivolja");
        penneArrabbiata.AddAllergen("Gluten");

        // Sallader
        var caesarSalad = new MenuItem(nextMenuItemId++, "Caesar Sallad",
            "Krispsallad, krutonger, parmesan och caesar-dressing",
            85.0, "Sallad", 8);
        caesarSalad.AddIngredient("Krispsallad", "Krutonger", "Parmesan", "Caesar-dressing");
        caesarSalad.AddAllergen("Gluten", "Laktos", "Ägg");

        // Drycker
        var cocaCola = new MenuItem(nextMenuItemId++, "Coca Cola",
            "33cl burk", 25.0, "Dryck", 1);

        var mineralWater = new MenuItem(nextMenuItemId++, "Mineralvatten",
            "50cl flaska", 20.0, "Dryck", 1);

        // Lägg till alla items till menu
        var allItems = new List<MenuItem>
        {
            margherita, hawaii, kebabPizza, quattroStagioni,
            spaghettiCarbonara, penneArrabbiata,
            caesarSalad,
            cocaCola, mineralWater
        };

        foreach (var item in allItems)
        {
            AddMenuItem(item);
        }
    }

    private void AddMenuItem(MenuItem item)
    {
        menu[item.Id] = item;

        if (!menuByCategory.ContainsKey(item.Category))
        {
            menuByCategory[item.Category] = new List<MenuItem>();
        }
        menuByCategory[item.Category].Add(item);
    }

    public void ShowMenu(string category = null)
    {
        Console.WriteLine("\n🍕 MARCUS PIZZERIA - MENY 🍕");
        Console.WriteLine("".PadRight(50, '='));

        var categoriesToShow = category != null
            ? new[] { category }
            : menuByCategory.Keys.OrderBy(k => k);

        foreach (var cat in categoriesToShow)
        {
            if (menuByCategory.ContainsKey(cat))
            {
                Console.WriteLine($"\n📂 {cat.ToUpper()}:");
                Console.WriteLine("".PadRight(30, '-'));

                var itemsInCategory = menuByCategory[cat]
                    .Where(i => i.IsAvailable)
                    .OrderBy(i => i.Price);

                foreach (var item in itemsInCategory)
                {
                    Console.WriteLine($"  {item.Id}. {item}");
                    if (item.Description.Length > 0)
                    {
                        Console.WriteLine($"     {item.Description}");
                    }
                }
            }
        }
        Console.WriteLine();
    }

    public Order CreateOrder(string customerName, string phone = "")
    {
        var order = new Order(nextOrderId++, customerName, phone);
        orders[order.OrderId] = order;

        // Lägg till kund om ny
        if (!customers.ContainsKey(phone) && !string.IsNullOrEmpty(phone))
        {
            customers[phone] = new Customer(customerName, phone);
        }

        Console.WriteLine($"📝 Ny beställning skapad: #{order.OrderId} för {customerName}");
        return order;
    }

    public bool AddItemToOrder(int orderId, int menuItemId, int quantity = 1, params string[] specialRequests)
    {
        if (!orders.ContainsKey(orderId))
        {
            Console.WriteLine($"❌ Order #{orderId} finns inte!");
            return false;
        }

        if (!menu.ContainsKey(menuItemId))
        {
            Console.WriteLine($"❌ Menu item #{menuItemId} finns inte!");
            return false;
        }

        var order = orders[orderId];
        var menuItem = menu[menuItemId];

        if (!menuItem.IsAvailable)
        {
            Console.WriteLine($"❌ {menuItem.Name} är inte tillgänglig just nu!");
            return false;
        }

        order.AddItem(menuItem, quantity, specialRequests);
        Console.WriteLine($"✅ Lade till {quantity}x {menuItem.Name} till order #{orderId}");

        return true;
    }

    public void ShowOrder(int orderId)
    {
        if (orders.ContainsKey(orderId))
        {
            orders[orderId].PrintReceipt();
        }
        else
        {
            Console.WriteLine($"❌ Order #{orderId} finns inte!");
        }
    }

    public void UpdateOrderStatus(int orderId, OrderStatus newStatus)
    {
        if (orders.ContainsKey(orderId))
        {
            var order = orders[orderId];
            var oldStatus = order.Status;
            order.Status = newStatus;

            Console.WriteLine($"📋 Order #{orderId} status: {oldStatus} → {newStatus}");

            if (newStatus == OrderStatus.Ready)
            {
                Console.WriteLine($"🔔 {order.CustomerName}, din beställning är klar för hämtning!");
            }
        }
        else
        {
            Console.WriteLine($"❌ Order #{orderId} finns inte!");
        }
    }

    public void ShowAllOrders(OrderStatus? filterByStatus = null)
    {
        Console.WriteLine("\n📋 ALLA BESTÄLLNINGAR:");

        var ordersToShow = filterByStatus.HasValue
            ? orders.Values.Where(o => o.Status == filterByStatus.Value)
            : orders.Values;

        ordersToShow = ordersToShow.OrderByDescending(o => o.OrderTime);

        foreach (var order in ordersToShow)
        {
            Console.WriteLine($"#{order.OrderId} - {order.CustomerName} " +
                             $"({order.Status}) - {order.Total:C} - {order.OrderTime:HH:mm}");
        }
        Console.WriteLine();
    }

    public void ShowDailyStats()
    {
        var today = DateTime.Today;
        var todayOrders = orders.Values.Where(o => o.OrderTime.Date == today).ToList();

        Console.WriteLine($"\n📊 DAGENS STATISTIK ({today:yyyy-MM-dd}):");
        Console.WriteLine("".PadRight(40, '='));

        Console.WriteLine($"📈 Antal beställningar: {todayOrders.Count}");

        if (todayOrders.Any())
        {
            var totalRevenue = todayOrders.Sum(o => o.Total);
            var averageOrder = todayOrders.Average(o => o.Total);

            Console.WriteLine($"💰 Total omsättning: {totalRevenue:C}");
            Console.WriteLine($"📊 Genomsnittlig beställning: {averageOrder:C}");

            // Mest populära rätt
            var itemStats = todayOrders.SelectMany(o => o.Items)
                                      .GroupBy(i => i.MenuItem.Name)
                                      .Select(g => new {
                                          Name = g.Key,
                                          Quantity = g.Sum(i => i.Quantity),
                                          Revenue = g.Sum(i => i.ItemTotal)
                                      })
                                      .OrderByDescending(x => x.Quantity);

            Console.WriteLine("\n🏆 POPULÄRASTE RÄTTER IDAG:");
            foreach (var item in itemStats.Take(5))
            {
                Console.WriteLine($"  • {item.Name}: {item.Quantity}st ({item.Revenue:C})");
            }

            // Status breakdown
            var statusStats = todayOrders.GroupBy(o => o.Status)
                                        .Select(g => new { Status = g.Key, Count = g.Count() });

            Console.WriteLine("\n📋 ORDERSTATUS:");
            foreach (var status in statusStats)
            {
                Console.WriteLine($"  • {status.Status}: {status.Count}");
            }
        }

        Console.WriteLine();
    }

    public void ShowPopularItems()
    {
        Console.WriteLine("\n🏆 POPULÄRASTE RÄTTER (ALL TIME):");

        var popularItems = menu.Values
            .Where(m => m.TimesOrdered > 0)
            .OrderByDescending(m => m.TimesOrdered)
            .Take(10);

        foreach (var item in popularItems)
        {
            Console.WriteLine($"  {item.TimesOrdered}x {item.Name} ({item.Category})");
        }
        Console.WriteLine();
    }

    // Customer loyalty tracking
    public void ShowCustomerStats()
    {
        var customerOrders = orders.Values
            .Where(o => !string.IsNullOrEmpty(o.CustomerPhone))
            .GroupBy(o => o.CustomerPhone)
            .Select(g => new {
                Phone = g.Key,
                Name = g.First().CustomerName,
                OrderCount = g.Count(),
                TotalSpent = g.Sum(o => o.Total),
                LastOrder = g.Max(o => o.OrderTime)
            })
            .OrderByDescending(c => c.TotalSpent);

        Console.WriteLine("\n👥 KUNDSTATISTIK:");
        Console.WriteLine("".PadRight(50, '='));

        foreach (var customer in customerOrders.Take(10))
        {
            var daysSinceLastOrder = (DateTime.Now - customer.LastOrder).Days;
            Console.WriteLine($"{customer.Name} ({customer.Phone}):");
            Console.WriteLine($"  📈 {customer.OrderCount} beställningar, {customer.TotalSpent:C} totalt");
            Console.WriteLine($"  📅 Senaste beställning: {daysSinceLastOrder} dagar sedan");
            Console.WriteLine();
        }
    }
}

// Customer class for loyalty tracking
public class Customer
{
    public string Name { get; set; }
    public string Phone { get; set; }
    public DateTime FirstOrder { get; set; }
    public int TotalOrders { get; set; }
    public double TotalSpent { get; set; }

    public Customer(string name, string phone)
    {
        Name = name;
        Phone = phone;
        FirstOrder = DateTime.Now;
        TotalOrders = 0;
        TotalSpent = 0;
    }
}

// Demo program
class RestaurantDemo
{
    static void Main()
    {
        Console.WriteLine("🍕 VÄLKOMMEN TILL MARCUS PIZZERIA! 🍕\n");

        var restaurant = new RestaurantManager();

        // Visa menyn
        restaurant.ShowMenu();

        // Simulera flera beställningar
        Console.WriteLine("📝 SIMULERAR BESTÄLLNINGAR:");

        // Order 1: Anna beställer pizza
        var order1 = restaurant.CreateOrder("Anna Andersson", "070-1234567");
        restaurant.AddItemToOrder(order1.OrderId, 1, 1); // Margherita
        restaurant.AddItemToOrder(order1.OrderId, 8, 2); // 2x Coca Cola
        restaurant.ShowOrder(order1.OrderId);

        // Order 2: Erik beställer pasta med specialförfrågningar
        var order2 = restaurant.CreateOrder("Erik Eriksson", "070-7654321");
        restaurant.AddItemToOrder(order2.OrderId, 5, 1, "Extra bacon", "Mindre salt"); // Carbonara
        restaurant.AddItemToOrder(order2.OrderId, 7, 1); // Caesar sallad
        restaurant.AddItemToOrder(order2.OrderId, 9, 1); // Mineralvatten
        restaurant.ShowOrder(order2.OrderId);

        // Order 3: Maria beställer flera pizzor
        var order3 = restaurant.CreateOrder("Maria Millionär", "070-9876543");
        restaurant.AddItemToOrder(order3.OrderId, 2, 2); // 2x Hawaii
        restaurant.AddItemToOrder(order3.OrderId, 3, 1); // Kebabpizza
        restaurant.AddItemToOrder(order3.OrderId, 4, 1, "Extra stark"); // Quattro Stagioni
        restaurant.ShowOrder(order3.OrderId);

        // Uppdatera order status
        restaurant.UpdateOrderStatus(order1.OrderId, OrderStatus.Confirmed);
        restaurant.UpdateOrderStatus(order1.OrderId, OrderStatus.InPreparation);
        restaurant.UpdateOrderStatus(order1.OrderId, OrderStatus.Ready);

        restaurant.UpdateOrderStatus(order2.OrderId, OrderStatus.Confirmed);
        restaurant.UpdateOrderStatus(order3.OrderId, OrderStatus.Confirmed);

        // Visa alla orders
        restaurant.ShowAllOrders();

        // Visa bara pending orders
        Console.WriteLine("PENDING ORDERS:");
        restaurant.ShowAllOrders(OrderStatus.Confirmed);

        // Statistik
        restaurant.ShowDailyStats();
        restaurant.ShowPopularItems();
        restaurant.ShowCustomerStats();

        // Visa specifik kategori
        Console.WriteLine("🍝 BARA PASTA:");
        restaurant.ShowMenu("Pasta");
    }
}
```

**Din uppgift:**
1. Lägg till inventory tracking för ingredienser
2. Implementera table reservations system
3. Skapa staff scheduling med olika roller

---

## 🎯 Sammanfattning

Du behärskar nu Collections för verkliga problem! Du kan:

- ✅ Använda Lists för dynamiska samlingar
- ✅ Implementera Dictionaries för snabb sökning
- ✅ Kombinera olika datastrukturer effektivt
- ✅ Använda LINQ för kraftfull datamanipulation
- ✅ Bygga komplexa system med nested collections
- ✅ Optimera prestanda med rätt datastruktur
- ✅ Hantera stora datamängder smart

**Nästa steg:** Kombinera Collections med databaser och API:er för fullständiga applikationer!

## 🤣 Obligatorisk Dad Joke

Varför älskar programmerare Dictionary collections?

För att de alltid har rätt nyckel till lösningen! 🗝️📚
