using System;

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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cachorro Dog = new Cachorro();
            Dog.Raça = "Poodle";
            Dog.Apelido = "Hex";
            Dog.Peso = 1.6f;
            Dog.Sexo = "Masculino";
            Dog.Comprimento = 4f;
            Dog.Cor = "Amarelo";

            Console.WriteLine(Dog.ToString());
            Dog.Latir();
            Dog.Morder();
            Dog.Correr();
            Console.WriteLine(Dog.Descricao("Adalberto"));


        }
    }
}
