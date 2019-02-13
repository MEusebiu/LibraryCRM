using Autofac;
using LibraryCRM.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCRM.Repository
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<BookRepository>().As<IBookRepository>();
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>();

            return builder.Build();
        }
    }
}
