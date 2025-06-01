using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_console_app
{
    
    public class book
    {
        public int bookid { get; }

        public book(int Bookid)
        {
            bookid = Bookid;
        }

        private string title;
        public string Title
        {
            //get { return title; } is used so that you can safely and flexibly let outside code read the value of the private title field.
            get { return title; }   
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title cannot be empty or whitespace.");
                }
                title = value;
            }
        }

    }

    
}
    