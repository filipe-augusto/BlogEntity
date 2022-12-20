// See https://aka.ms/new-console-template for more information

// dotnet tool install --global dotnet-ef
//dotnet add package Microsoft.EntityFrameWork.SqlServer
using blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

//Console.Clear();
void2_3();
//modulo2_1();
//modulo1();


void void2_3(){
        Console.Clear();
    using var context = new BlogDataContext();  

    var post = context.Posts.Include(x => x.Author)
    .Include(x => x.Category)
    .OrderByDescending(x => x.LastUpdateDate)
    .FirstOrDefault(); //Pegando o primeiro item.

        post.Author.Name = "Teste123";
        context.Posts.Update(post);
        context.SaveChanges();
}

void modulo2_2(){
        using var context = new BlogDataContext();  
        var posts = context.Posts.AsNoTracking()
        .Include(x => x.Author)
        .Include(x => x.Category)
        //.ThenInclude(x=>x.Endereco) subselect
        .Where(x => x.AuthorId ==6)
        .OrderBy(x => x.LastUpdateDate).ToList();

        foreach(var post in posts){
                System.Console.WriteLine($"Title: {post.Title} Author: {post.Author?.Email} - Categoria: {post.Category.Name}");
        }
}

void modulo2_1(){
    using var context = new BlogDataContext();

    var user =new User{
        Name = "Filipe Augusto",
        Slug = "filipeaugusto",
        Email = "filipe@balta.io",
        Bio= "11x microsoft MVP",
        Image = "https//balta.io",
        PasswordHash = "123098457"
    };
    var category = new Category{Name = "backend", Slug = "backend"};
//scope identity
    var post = new Post{
        Author = user,
        Category = category,
        Body = "<p>hello world</p>",
        Slug = "comecando-com-df-core",
        Summary = "neste artigo vamos aprender ef core",
        Title = "começando com ef core",
        CreateDate = DateTime.Now,
        LastUpdateDate = DateTime.Now
    };

         context.Posts.Add(post);
        context.SaveChanges();
}

void modulo1(){
using (var context = new BlogDataContext()){
     

   // var tag = new Tag{Name="ASP.NET", Slug="aspnet"};
        // context.Tags.Add(tag);
        // context.SaveChanges();//salva no banco

        //reidratação UPDATE
        // var tag = context.Tags.FirstOrDefault(x => x.Id ==  3);
        // tag.Name = ".NET";
        // tag.Slug = "dotnet";
        // context.Update(tag);
        // context.SaveChanges();
        //obs sempre que precisar atualizar ou deletar precisa resgatar o objeto do banco
       
        //DELETE
        // var tag = context.Tags.FirstOrDefault(x => x.Id ==  3);
        // context.Remove(tag);
        // context.SaveChanges();

       // var tags = context.Tags.ToList();//sempre que tiver um .tolist estou executando a query
        //ERRADO
       // var tags_ERRADO = context.Tags.ToList().Where(x=>x.Name.Contains(".NET"));
        // Da forma acima ele consuta todas as tags  e depois aplica o filtro

        //CERTO - O TOLIST SEMPRE SEMPRE SERÁ O ULTIMO
       //    var tags_CERTO = context.Tags.Where(x=>x.Name.Contains(".NET")).ToList();
        // foreach(var tag in tags){
        //     Console.WriteLine(tag.Name);
        // }
//         var tags = context.Tags.AsNoTracking().ToList();

//         var tag = context.Tags.AsNoTracking().
//         FirstOrDefault(x => x.Id == 3);//se houver mais que 1 ele traz o primeiro
//         //se não hover registro ele retorna null
//          var tag2 = context.Tags.AsNoTracking().
//         Single(x => x.Id == 3); //se houver mais que 1 ele da erro

//        var tag3 = context.Tags.AsNoTracking().
//         First(x => x.Id == 3); //se houver mais que 1 ele da erro
//         //se não houver registro ele da erro
//         System.Console.WriteLine(tag?.Name);


}
}