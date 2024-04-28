using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTZMDotNetCore.ConsoleApp
{
    internal class EFCoreExample
    {
        private readonly AppDbContext db = new AppDbContext();
        public void Run()
        {
            // Read();
            // Edit(1);
            //Edit(3);
            //Create("Author New", "Title New", "Content New");
            //Update(3, "Author 11", "Title 11", "Content 11");
            Delete(1003);

        }


        private void Read()
        {

            var list = db.blogs.ToList();

            foreach (BlogDto item in list)
            {
                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogContent);
                Console.WriteLine("------------------");
            }
        }

        private void Edit(int id)
        {
            var item = db.blogs.FirstOrDefault(x => x.BlogId == id);

            if (item is null)
            {
                Console.WriteLine("No DataFound");
                return;
            }

            Console.WriteLine(item.BlogId);
            Console.WriteLine(item.BlogAuthor);
            Console.WriteLine(item.BlogTitle);
            Console.WriteLine(item.BlogContent);
            Console.WriteLine("------------------");

        }

        private void Create(string author, string title, string content)
        {
            var item = new BlogDto
            {
                BlogAuthor = author,
                BlogTitle = title,
                BlogContent = content
            };
            db.Add(item);
            int result = db.SaveChanges();
            string message = result > 0 ? "saving successful" : "saving fail";
            Console.WriteLine(message);
        }


        private void Update(int id, string author, string title, string content)
        {
            var item = db.blogs.FirstOrDefault(x => x.BlogId == id);

            if (item is null)
            {
                Console.WriteLine("No DataFound");
                return;
            }

            item.BlogAuthor = author;
            item.BlogTitle = title;
            item.BlogContent = content;
            int result = db.SaveChanges();
            string message = result > 0 ? "Updating successful" : "Updating fail";
            Console.WriteLine(message);

        }

        private void Delete(int id)
        {

            var item = db.blogs.FirstOrDefault(x => x.BlogId == id);

            if (item is null)
            {
                Console.WriteLine("No DataFound");
                return;
            }

            db.Remove(item);
            int result = db.SaveChanges();
            string message = result > 0 ? "Deleting successful" : "Deleting fail";
            Console.WriteLine(message);
        }
    }

}
