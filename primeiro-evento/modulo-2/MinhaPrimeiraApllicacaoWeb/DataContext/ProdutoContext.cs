using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using MinhaPrimeiraApllicacaoWeb.Models;
namespace MinhaPrimeiraApllicacaoWeb.DataContext;

public class ProdutoContext : DbContext
{
    public DbSet<ProdutoModel> Produtos { get; set; }

    public ProdutoContext(DbContextOptions<ProdutoContext> options)
     : base(options)
    {
    }
}