
using System.Collections.Generic;
using System.Linq;
using MiTutor.Models;

namespace MiTutor.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MiTutorContext context)
        {
           /* 
		    context.Database.EnsureCreated();

            var un = new University();
            un.Name="3r23";

            context.Universities.Add(un);

            var u = new User();
            u.Email="dfscsd";

            var p = new Person();
            p.Name="E23";
            p.User=u; 
            p.University=un;

            var tut = new Tutor();
            tut.Points=1;
            tut.Person=p;
            context.Tutors.Add(tut);

            var su = new Subject();
            su.Name="23e32";
            context.Subjects.Add(su);

            var to = new Topic();
            to.Name="32e2r";
            to.TopicId=3;
            to.Subject=su;
            context.Topics.Add(to);
    
            var tu = new TutoringSession();
            tu.Tutor=tut;
            tu.Place="vdfvav";
            tu.TopicTutoringSessions = new List<TopicTutoringSession>();
            context.TutoringSessions.Add(tu); 
            

            var tAux= new TopicTutoringSession();
            tAux.Topic=to;
            tAux.TutoringSession=tu;

            tu.TopicTutoringSessions.Add(tAux);  
            context.SaveChanges();  */

			
			/*context.Universities.Remove(context.Universities.Where(ux => ux.UniversityId==1).First());
			context.SaveChanges(); */
		



        }
    }
}