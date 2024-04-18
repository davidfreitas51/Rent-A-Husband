using Microsoft.EntityFrameworkCore;
using RentAHusband.Models;

namespace RentAHusband.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RentAHusbandContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RentAHusbandContext>>()))
            {
                // Look for any movies.
                if (context.MaridoDeAluguel.Any())
                {
                    return;   // DB has been seeded
                }
                context.MaridoDeAluguel.AddRange(
                    new MaridoDeAluguel
                    {
                        Nome = "Antônio Almeida Silva",
                        Especialidade = "Eletricista",
                        Telefone = "(11) 95242-1290",
                        Cidade = "São Paulo",
                        Estado = "SP"
                    },
                    new MaridoDeAluguel
                    {
                        Nome = "Pedro Carlos de Souza",
                        Especialidade = "Alvenaria",
                        Telefone = "(21) 91331-5523",
                        Cidade = "Rio de Janeiro",
                        Estado = "RJ"
                    },
                    new MaridoDeAluguel
                    {
                        Nome = "Wesley Rafael Nascimento",
                        Especialidade = "Metalúrgica",
                        Telefone = "(88) 97544-4885",
                        Cidade = "Tianguá",
                        Estado = "Ceará"
                    },
                    new MaridoDeAluguel
                    {
                        Nome = "Marcos Mendes Pereira",
                        Especialidade = "Mecânica",
                        Telefone = "(85) 95623-7123",
                        Cidade = "Fortaleza",
                        Estado = "Ceará"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
