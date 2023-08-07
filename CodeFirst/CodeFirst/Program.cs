using CodeFirst;
using Microsoft.EntityFrameworkCore;
using Migrations.Entites;
using Migrationss.Data;

public class Program
{
    public static async Task Main(string[] args)
    {
        using (var context = new AppDbcontext()) {

            await context.Database.EnsureCreatedAsync();
            if (!await context.Set<Individual>().AnyAsync()){
                context.Set<Individual>().AddRange(SeedData.LoadIndividuals());
                    }
            if (!await context.Set<Coobrate>().AnyAsync())
            {
                context.Set<Coobrate>().AddRange(SeedData.LoadCorporates());
            }
            if (!await context.Set<Course>().AnyAsync())
            {
                context.Set<Course>().AddRange(SeedData.load_courses());
            }
            if (!await context.Set<Office>().AnyAsync())
            {
                context.Set<Office>().AddRange(SeedData.load_Ofiicess());
            }
            if (!await context.Set<Instructor>().AnyAsync())
            {
                context.Set<Instructor>().AddRange(SeedData.load_Instructors ());
            }
            if (!await context.Set<Enrollment>().AnyAsync())
            {
                context.Set<Enrollment>().AddRange(SeedData.load_Enrollments());
            }
            //if (!await context.Set<Student>().AnyAsync())
            //{
            //    context.Set<Student>().AddRange(SeedData.LoadStudents());
            //}
            if (!await context.Set<Schedule>().AnyAsync())
            {
                context.Set<Schedule>().AddRange(SeedData.load_Schedules());
            }
            if (!await context.Set<Section>().AnyAsync())
            {
                context.Set<Section>().AddRange(SeedData.LoadSections());
            }
            await context.SaveChangesAsync();
        }
        Console.ReadKey();
    }
}