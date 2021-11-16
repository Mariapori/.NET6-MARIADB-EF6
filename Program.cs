TietokantaContext db = new TietokantaContext();
Console.WriteLine("Mitä haluat tehdä?");
Console.WriteLine("A: Lue kantaa");
Console.WriteLine("B: Lisää tietue");
var vastaus = Console.ReadLine();

if(vastaus?.ToUpper() == "A")
{
    Console.WriteLine("Tietueet:");
    var tietueet = db.Tietueet.ToList();
    int counter = 1;
    foreach(var item in tietueet)
    {
        Console.WriteLine(counter.ToString() + " " + item.Nimi);
        counter++;
    }
}
if(vastaus?.ToUpper() == "B")
{
    Console.WriteLine("Tietueen nimi:");
    var tietueNimi = Console.ReadLine();
    tietue asd = new tietue();
    asd.Nimi = tietueNimi ?? "";
    asd.PVM = DateTime.Now;
    db.Tietueet.Add(asd);
    db.SaveChanges();
}