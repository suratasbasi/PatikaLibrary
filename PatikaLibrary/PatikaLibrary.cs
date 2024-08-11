using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaLibraryPratica
{
    public class PatikaLibrary
    {
        public string _book;
        public string _authorName;
        public string _authorSurname;
        public int _numberOfPages;
        public string _publishingHouse;
        public DateTime _registrationDate;

        public string Book
        { get { return _book; } set { _book = value; } }

        public string AuthorName
        { get { return _authorName; } set { _authorName = value; } }

        public string AuthorSurname
        { get { return _authorSurname; } set { _authorSurname = value; } }

        public int NumberOfPages
        { get { return _numberOfPages; } set { _numberOfPages = value; } }

        public string PublishingHouse
        { get { return _publishingHouse; } set { _publishingHouse = value; } }

        public DateTime RegistrationDate
        { get { return _registrationDate; } set { _registrationDate = value; } }


        public PatikaLibrary()
        {
            _book = "";
            _authorName = "";
            _authorSurname = "";
            _numberOfPages = 0;
            _publishingHouse = "";
            _registrationDate = DateTime.Now;
        }

        public PatikaLibrary(string book, string authorName, string authorSurname, int numberOfPages, string publishingHouse)
        {
            _book = book;
            _authorName = authorName;
            _authorSurname = authorSurname;
            _numberOfPages = numberOfPages;
            _publishingHouse = publishingHouse;
            _registrationDate = DateTime.Now;
        }


        public void ShowInformation()
        {
            Console.WriteLine("Kitabın adı: " + _book + "\nYazarın adı ve soyadı: " + _authorName + " " + _authorSurname + "\nSayfa sayısı: " + _numberOfPages + "\nKayıt tarihi: " + _registrationDate);
        }


    }
}

//
/*
Class (Sınıf): Sınıf, belirli bir türden nesneler oluşturmak için bir şablondur. Yukarıdaki örnekte, `PatikaLibrary` sınıfı, kitaplarla ilgili bilgileri depolayan ve işlem yapan bir şablondur.

Property (Özellik): Özellikler, bir sınıfın durumunu temsil eden verilerdir. `Book`, `AuthorName`, `AuthorSurname`, `NumberOfPages`, `PublishingHouse` ve `RegistrationDate` bu sınıfın özellikleridir.

New: "New" anahtar kelimesi, bir sınıfın yeni bir örneğini (nesnesini) oluşturmak için kullanılır. `new PatikaLibrary()` ifadesi, `PatikaLibrary` sınıfının yeni bir örneğini oluşturur.

Constructor (Yapıcı Metot): Yapıcı metot, bir sınıfın yeni bir örneği oluşturulduğunda otomatik olarak çağrılan özel bir metottur. `PatikaLibrary()` ve `PatikaLibrary(string book, string authorName, string authorSurname, int numberOfPages, string publishingHouse)` metotları, `PatikaLibrary` sınıfının yapıcı metotlarıdır. Bu metotlar, nesne oluşturulurken ilgili özelliklere başlangıç değerlerini atar.
*/
