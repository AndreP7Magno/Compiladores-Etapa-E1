using Antlr4.Runtime;
using System;

namespace Compiladores_Etapa_E1
{
    public class Program
    {
        static void Main(string[] args)
        {
            String c = "";
            c = Console.ReadLine();
            AntlrInputStream inputStream = new AntlrInputStream(c);

            GramaticaLexer lexer = new GramaticaLexer(inputStream);

            CommonTokenStream bts = new CommonTokenStream(lexer);
            bts.Fill();
            IToken tk = lexer.NextToken();
            tk.GetType();

            GramaticaParser p = new GramaticaParser(bts);
            p.start();
            Console.ReadKey();
        }
    }
}
