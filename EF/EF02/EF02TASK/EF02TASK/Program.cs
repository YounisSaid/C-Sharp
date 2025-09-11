using TASK.Contexts;
using TASK.Models;

namespace EF02TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ITIDbContext iTIDbContext = new ITIDbContext();
            #region Add

            Student student = new Student()
            {

                FName = "Younis",
                LName = "Said",
                Address = "Cairo, Egypt",
                Age = 21
            };
            //iTIDbContext.Add(student);
            //iTIDbContext.SaveChanges();
            #endregion



            #region Retrive

            //var result = iTIDbContext.Students.FirstOrDefault(x => x.ID ==2);
            //if(result != null)
            //{
            //    Console.WriteLine(result.ID);
            //}



            #endregion

            #region Update
            //var result = iTIDbContext.Students.FirstOrDefault(x => x.ID == 2);
            //if (result != null)
            //{
            //    result.LName = "Ali";
            //    iTIDbContext.SaveChanges();
            //}
            #endregion

            #region Delete

            //var result = iTIDbContext.Students.FirstOrDefault(x => x.ID == 2);
            iTIDbContext.Remove(student);
            iTIDbContext.SaveChanges();
            #endregion
        }
    }
}
