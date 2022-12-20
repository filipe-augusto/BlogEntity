// See https://aka.ms/new-console-template for more information

// dotnet tool install --global dotnet-ef
//dotnet add package Microsoft.EntityFrameWork.SqlServer
using blog.Models;
using Blog.Data;

using (var context = new BlogDataContext()){
        // var tag = new Tag{Name="ASP.NET", Slug="aspnet"};
        // context.Tags.Add(tag);
        // context.SaveChanges();//salva no banco

        //reidratação UPDATE
        var tag = context.Tags.FirstOrDefault(x => x.Id ==  3);
        tag.Name = ".NET";
        tag.Slug = "dotnet";
        context.Update(tag);
        context.SaveChanges();

}