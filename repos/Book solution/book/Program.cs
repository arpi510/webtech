using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
public class Book
    {
    private string bookName;
    private string bookAuthor;
    private string bookId;
    private string bookType;
    private int bookCopy;

   //public properties
   public string BookName
        {

            get { return bookName; }
            set { bookName = value; }
        }  
    public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
    public 