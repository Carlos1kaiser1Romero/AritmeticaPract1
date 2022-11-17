using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetica
{
    internal class Visita : aritmeticaBaseVisitor<int>
    {
        public override int VisitAritmetica([NotNull] aritmeticaParser.AritmeticaContext context)
        {
            Console.WriteLine($"Aritmetica: {context.GetText()}");
            return base.VisitAritmetica(context);
        }

        public override int VisitExpresion([NotNull] aritmeticaParser.ExpresionContext context)
        {
            Console.WriteLine($"Expresion: {context.GetText()}");
            return base.VisitExpresion(context);
        }

        public override int VisitFactor([NotNull] aritmeticaParser.FactorContext context)
        {
            Console.WriteLine($"Factor: {context.GetText()}");
            return base.VisitFactor(context);
        }

        public override int VisitTermino([NotNull] aritmeticaParser.TerminoContext context)
        {
            Console.WriteLine($"Termino: {context.GetText()}");
            return base.VisitTermino(context);
        }
    }
}
