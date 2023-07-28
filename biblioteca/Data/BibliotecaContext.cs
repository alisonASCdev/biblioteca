using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace biblioteca.data
{
    public class BibliotecaContext: DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
            
        }
    }
}
