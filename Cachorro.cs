using System;
using System.Collections.Generic;
using System.Text;

/*
* Disciplina:  Programação Orientada a Objetos
* Prof.:       Orlewilson B. Maia
* Autor:	   Grupo Alan Turing (C#)
* Data:        17/09/2019
* Descrição:   Primeira classe para apresentar um cachorro
* 
* 
*/

namespace Primeira_Classe
{
    class Cachorro
    {
        public string Cor { get; set; }
        public string Raça { get; set; }
        public string Apelido { get; set; }
        public string Sexo { get; set; }
        public float Comprimento { get; set; }
        public float Peso { get; set; }

        public void Latir() { Console.WriteLine("Au au"); }
        public void Morder() { Console.WriteLine("Mordendo"); }
        public void Correr() { Console.WriteLine("Correndo"); }

        public override string ToString()
        {
            var texto = $"apelido: {Apelido}";
            texto += "\nCor:\t" + Cor;
            texto += "\nRaça:\t" + Raça;
            texto += "\nComprimento:\t" + Comprimento;
            texto += "\nPeso:\t" + Peso;
            texto += "\nSexo:\t" + Sexo;
            return texto;

        }
        public string Descricao(string Apelido)
        {
            var texto = "apelido: " + Apelido + "\napelido 2: " + this.Apelido;
            return texto;
        }
    }
}
