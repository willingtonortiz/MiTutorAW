
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
             un.Name="test university";
             context.Universities.Add(un);

             var u = new User();
             u.Email="test@hotmail.com";
             u.Password="textPassword123";
             u.Username="User";

             var p = new Person();
             p.Name="Antony";
             p.LastName="Porras";
             p.Semester=5;
             p.User=u; 
             p.University=un;

             var tut = new Tutor();
             tut.Points=100000;
             tut.Person=p;
             context.Tutors.Add(tut); 

             var su = new Subject();
             su.Name="Calculo";
             context.Subjects.Add(su);

             var to = new Topic();
             to.Name="Derivadas";
             to.Subject=su;
             context.Topics.Add(to);

             to = new Topic();
             to.Name="Integrales";
             to.Subject=su;
             context.Topics.Add(to);




             su = new Subject();
             su.Name="Programacion2";
             context.Subjects.Add(su);

             to = new Topic();
             to.Name="Clases";
             to.Subject=su;
             context.Topics.Add(to);

             to = new Topic();
             to.Name="Formulario";
             to.Subject=su;
             context.Topics.Add(to);


             su = new Subject();
             su.Name="Arquitectura de software";
             context.Subjects.Add(su);

             to = new Topic();
             to.Name="Algoritmos de memoria";
             to.Subject=su;
             context.Topics.Add(to);


             to = new Topic();
             to.Name="Circuitos logicos";
             to.Subject=su;
             context.Topics.Add(to); 



            context.SaveChanges();


            /*context.Universities.Remove(context.Universities.Where(ux => ux.UniversityId==1).First());
			context.SaveChanges(); */
		



        }
    }
}