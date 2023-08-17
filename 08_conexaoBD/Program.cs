// See https://aka.ms/new-console-template for more information
using _08_conexaoBD;

Console.WriteLine("Hello, World!");
//ConexaoSimples conexaoSimples = new ConexaoSimples();

ConexaoFlexivel conexaoFlexivel= new ConexaoFlexivel();
conexaoFlexivel.executaQuery("SELECT * FROM tarefas;");
conexaoFlexivel.executaQuery("SELECT FROM WHERE id = 4;");