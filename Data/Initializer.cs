
using MiTutor.Models;

namespace MiTutor.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MiTutorContext context)
        {
            context.Database.EnsureCreated();
            
            var u = new User();
            u.Email="#2312";
            u.Password="343421";
            u.UserId=1;

            var t = new Tutor();
            t.User=u;
            t.Name="dfcd";
            t.Points=1;
           
            context.Tutors.Add(t);
           

            context.SaveChanges();
        }
    }
}