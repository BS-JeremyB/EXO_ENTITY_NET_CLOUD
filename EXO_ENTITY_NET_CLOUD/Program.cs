using EXO_ENTITY_NET_CLOUD.Context;
using EXO_ENTITY_NET_CLOUD.Entities;
using Microsoft.EntityFrameworkCore;


#region CREATE
//using (DataContext dc = new DataContext())
//{

//    dc.Films.Add(new Film
//    {
//        Titre = "Pacific Rim",
//        ActeurPrincipal = "Charlie Hunnam",
//        Realisateur = "Guillermo Del Toro",
//        AnneeDeSortie = 2013,
//        Genre = "Action"
//    });

//    try
//    {
//        dc.SaveChanges();
//    } catch (DbUpdateException e)
//    {
//        Console.WriteLine(e.Message);
//    }

//}

#endregion

#region READ

//using(DataContext dc = new DataContext())
//{
//    IEnumerable<Film> films = dc.Films.Where(x => x.AnneeDeSortie < 2001);


//    if (films is not null && films.Any())
//    {
//        foreach (Film f in films) 
//        {
//            Console.WriteLine($"{f.Id} : {f.Titre} | {f.ActeurPrincipal} | {f.Realisateur} | {f.AnneeDeSortie}| {f.Genre}");
//        }
//    }

//}


#endregion

#region UPDATE

//using (DataContext dc = new DataContext())
//{
//    IEnumerable<Film> films = dc.Films.Where(x => x.Titre.ToLower().Contains("star wars"));

//    if (films is not null && films.Any())
//    {
//        foreach(Film f in films)
//        {
//            f.ActeurPrincipal = "Harrison Ford";
//        }

//        try
//        {
//            dc.SaveChanges();
//        }catch (DbUpdateException e) 
//        {
//            Console.WriteLine(e.Message);
//        }
//    }
//}

#endregion


#region DELETE

//using (DataContext dc = new DataContext())
//{
//    IEnumerable<Film> films = dc.Films.Where(x => x.ActeurPrincipal.ToLower().Contains("hunnam"));

//    if (films is not null && films.Any())
//    {
//        foreach (Film f in films)
//        {
//            dc.Remove(f);
//        }

//        try
//        {
//            dc.SaveChanges();
//        }
//        catch (DbUpdateException e)
//        {
//            Console.WriteLine(e.Message);
//        }
//    }
//}

#endregion


using(DataContext dc = new DataContext())
{
    var resultat = dc.Films.Include(f => f.Realisateur)
                           .Include(f => f.AEmbaucheDesActeurs)
                           .ThenInclude(p => p.Personne).ToList();


    foreach (var film in resultat)
    {
        Console.WriteLine($"Titre : {film.Titre}\n" +
                          $"Realisé par : {film.Realisateur.Nom} {film.Realisateur.Prenom}\n" +
                          $"Année de sortie : {film.AnneeDeSortie}\n" +
                          $"Acteurs : ");
        foreach(var acteur in film.AEmbaucheDesActeurs)
        {
            Console.WriteLine($"Nom : {acteur.Personne.Nom} {acteur.Personne.Prenom}");
        }

        Console.WriteLine("-----------------------------");
    }
}
