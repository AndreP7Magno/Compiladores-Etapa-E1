using Antlr4.Runtime;
using System;

namespace Compiladores_Etapa_E1
{
    public class Program
    {
        static void Main(string[] args)
        {
            AntlrInputStream inputStream = new AntlrInputStream(Console.In);

            GramaticaLexer lexer = new GramaticaLexer(inputStream);

            CommonTokenStream bts = new CommonTokenStream(lexer);
            bts.Fill();
            IToken tk = lexer.NextToken();
            //tk.GetType();

            GramaticaParser p = new GramaticaParser(bts);
            p.start();
            Console.ReadKey();
        }
    }
}
