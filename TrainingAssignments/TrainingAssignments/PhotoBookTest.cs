using System;
using System.Collections.Generic;
using System.Text;
/*Create a C# program to manage a photo book using object-oriented programming.

To start, create a class called PhotoBook with a private attribute numPages of type int. It must also have a public method GetNumberPages that will return the number of photo book pages.

The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify the number of pages we want in the album.

There is also a BigPhotoBook class whose constructor will create an album with 64 pages.

Finally create a PhotoBookTest class to perform the following actions:

Create a default photo book and show the number of pages
Create a photo book with 24 pages and show the number of pages
Create a Big photo book and show the number of pages*/

namespace TrainingAssignments
{

    class PhotoBook
    {
        private int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int _numPages)
        {
            numPages = _numPages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }

       
    }

   class BigPhotoBook 
    {
        private int numPages;
        public BigPhotoBook()
        {
            numPages = 64;
        }

        public int GetNumberPages()
        {
            return numPages;
        }

    }
    class PhotoBookTest
    {
        public static void Main1()
        {
            PhotoBook pb = new PhotoBook();
            Console.WriteLine(pb.GetNumberPages());

            PhotoBook pb1 = new PhotoBook(24);
            Console.WriteLine(pb1.GetNumberPages());

            BigPhotoBook b = new BigPhotoBook();
            Console.WriteLine(b.GetNumberPages());
        }
    }
}
