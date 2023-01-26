﻿//using AspNetCore;
using EstudosMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using CursoAPI.Controllers;

namespace CursoTest
{
    public class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
        public CategoriasControllerTest() 
        { 
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<Context>();
            _categoria = new Categoria { Id=1, Descricao ="Teste categoria"};
            
            _mockContext.Setup( m => m.Categorias ).Returns( _mockSet.Object );
            
            _mockContext.Setup( m => m.Categorias.FindAsync(1))
                .ReturnsAsync(_categoria);
        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

            var testCategoria =  await service.GetCategoria(1);

            _mockSet.Verify( m => m.FindAsync(1), 
                Times.Once());

            Assert.Equal(_categoria, testCategoria );
        }

    }
}
