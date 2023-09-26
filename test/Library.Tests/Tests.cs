namespace Library.Tests;
using System;
using System.Collections.Generic; 

public class Test
{
    [Test]
        public void CalcularSalidaAND_DevuelveTrueSiTodasLasEntradasSonTrue()
        {
            // Arrange
            var compuerta = new CompuertaAND();
            compuerta.AgregarEntrada(true);
            compuerta.AgregarEntrada(true);

            // Act
            bool resultado = compuerta.CalcularSalida();

            // Assert
            Assert.True(resultado);
        }


    [Test]
        public void CalcularSalidaNOT_DevuelveFalseSiLaEntradaEsTrue()
        {
            // Arrange
            var compuerta = new CompuertaNOT();
            compuerta.AgregarEntrada(true);

            // Act
            bool resultado = compuerta.CalcularSalida();

            // Assert
            Assert.False(resultado);
        }

    [Test]
        public void CalcularSalidaOR_DevuelveTrueSiAlMenosUnaEntradaEsTrue()
        {
            // Arrange
            var compuerta = new CompuertaOR();
            compuerta.AgregarEntrada(false);
            compuerta.AgregarEntrada(true);

            // Act
            bool resultado = compuerta.CalcularSalida();

            // Assert
            Assert.True(resultado);
        }
    [Test]
        public void CalcularSalidaCompuertaGarage_Test()
        {
            //Arrange

            CompuertaGarage CompuertaTest = new CompuertaGarage(true, true, true);

            //Act
            bool resultado = CompuertaTest.CalcularSalida();

            //Assert

            Assert.True(resultado);
            
        }

}
