using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        string author;
        string title;
        int numPages;
        
        public void setTitle 
            (string newTitle )
        {
            title = newTitle;
        }
        public string 
            getTitle()
           
        {
            return title;
        }

    }
}
