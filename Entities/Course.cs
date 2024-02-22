namespace IntroR.Entities;

public class Course  // veri tutucu sınıflar da denebilir 
{
    //Aslında bir kurs ama kursun içinde dallanmış veriler var. Buna CLASS denir
    
    //PROPERTY
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    
}