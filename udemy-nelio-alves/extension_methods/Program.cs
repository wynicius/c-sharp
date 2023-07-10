using System;

DateTime dt = new DateTime(2013, 09, 02, 12, 00, 00);
System.Console.WriteLine(dt.ElapsedTime());

string descricaoPost = "Vídeo novo no canal, falando sobre dinossauros intergaláticos: como vivem, de qual planeta vieram e o porquê de terem pedido asilo na terra. \nQuem não está seguindo ainda o canal, para não perder mais nada, se inscreve lá, é de graça! \n\nAbraços Txurma!";

System.Console.WriteLine(descricaoPost.Cut(15));