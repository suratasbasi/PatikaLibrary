using PatikaLibraryPratica;
public class Program
{
    public static void Main()
    {
        PatikaLibrary information = new PatikaLibrary("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi");
        information.ShowInformation();

        PatikaLibrary information2 = new PatikaLibrary();
        information2.ShowInformation();
    }
}