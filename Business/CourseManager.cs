using IntroR.Entities;

namespace IntroR.Business;

public class CourseManager  //operasyon tutucu sınıf diyebiliriz.
{
    Course[] courses = new Course[3]; // GLOBAL değişken olarak tanımlandı

    //Constructor -- Yapıcı Blok 
    public CourseManager()
    {
        //Burası NEW lendiği zaman çalışır 
        Console.WriteLine("Başladı");

        // Constructor ilk oluştuğun sanki bu kurslar DB den gelmiş gibi data lar eklendi. 

        Course course1 = new Course(); // Referans oluşturmak 
        course1.Id = 1;
        course1.Name = "C#";
        course1.Description = ".Net 8..";
        course1.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Java 17...";
        course2.Price = 10;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python 3.12...";
        course3.Price = 15;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
        
    }
    
    //Method
    public Course[] GetALL() // GetAll methodu çağrıldığın Course[] arrayi verilecek 
    {
        //DB den çekilen veriler olur.
        
        //Console.WriteLine("Kurslar listelendi.");

        return courses;
        
    }
}
