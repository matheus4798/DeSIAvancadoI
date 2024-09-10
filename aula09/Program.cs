﻿public class Program{
    public static void Main(){
        Cliente cliente1 = new Cliente(1, "joao");
        Cliente cliente2 = new Cliente(2, "Maria");

        Produto produto1 = new Produto(1,"Notebook", 3500.00M);
        Produto produto2 = new Produto(2,"Celular", 1800.00M);
        Produto produto3 = new Produto(3,"Tablet", 1200.00M);
        Produto produto4 = new Produto(4,"Fone de Ouvido", 150.00M);

        Compra compra1 = new Compra(cliente1);
        compra1.AdicionaProduto(produto1);
        compra1.AdicionaProduto(produto2);
        compra1.AdicionaProduto(produto4);

        Compra compra2 = new Compra(cliente2);
        compra2.AdicionaProduto(produto1);
        compra2.AdicionaProduto(produto3);
        compra2.AdicionaProduto(produto2);

        Console.WriteLine(compra1);
        Console.WriteLine(compra2);
    }
}