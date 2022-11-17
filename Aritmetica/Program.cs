using Antlr4.Runtime;
using Aritmetica;
string input = "22*5+5-8/2";
ICharStream Stream = CharStreams.fromString(input);

aritmeticaLexer lexer = new aritmeticaLexer(Stream);

CommonTokenStream tokens = new CommonTokenStream(lexer);    

aritmeticaParser parser = new aritmeticaParser(tokens);

var tree = parser.aritmetica();

Visita vistado = new Visita();

int resultado =vistado.Visit(tree);



