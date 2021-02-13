using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Book
    {
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

       
        
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }


        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }


        public string GetPages()
        {
            return title;
        }
        public void SetPages(int pages)
        {
            this.pages = pages;
        }


        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }


        


    }
}
