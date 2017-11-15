grammar Gramatica;

/*
 * Parser Rules
 */
options {
    language=CSharp3;
    namespace=Compiladores_Etapa_E1;
}

//@parser::
@header{
	using Antlr4.Runtime;
	using System;
    }
@members{
    static String simbolo = "";
    static String ReconheceSimbolo(IToken token){
        return token.Text;
    }
}


start: gramm EOF 
     ;
gramm: e;

e: e OPSS t{
    simbolo = ReconheceSimbolo($OPSS);
    if(simbolo == "+")
        Console.WriteLine("add");
    else if(simbolo == "-")
        Console.WriteLine("sub");
} | t;
t: t OPMD f{
simbolo = ReconheceSimbolo($OPMD);
if(simbolo == "*")
Console.WriteLine("mul");
else if(simbolo == "/")
Console.WriteLine("div");
}| f;
f: OPEN e CLOSE | ID {
Console.WriteLine("push " + ReconheceSimbolo($ID));
}| OPSS ID {Console.WriteLine("push " + ReconheceSimbolo($OPSS) + ReconheceSimbolo($ID)); };


/*
 * Lexer Rules
 */

OPEN: '(';

CLOSE: ')';

ID: [0-9]+[.0-9]*;

OPMD: ('*' | '/');

OPSS: ('+' | '-');

SPACE: (' '| '\t' | '\n')+ -> skip;