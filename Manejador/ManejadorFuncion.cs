using System;
using System.Text.RegularExpressions;
using org.mariuszgromada.math.mxparser;

namespace Manejador
{
    public class ManejadorFuncion
    {
        
        public string ProcesarFuncion(string latex)
        {
            if (string.IsNullOrWhiteSpace(latex))
                throw new Exception("No hay función ingresada.");

            string expr = latex;
            expr = LimpiarComandosFormato(expr);
            expr = ConvertirExponentes(expr);
            expr = ConvertirFracciones(expr);
            expr = ConvertirFunciones(expr);
            expr = Limpiar(expr);
            expr = AgregarMultiplicacionImplicita(expr);
            return expr;
        }


        public bool TryProcesar(string latex, out string expresion, out string error)
        {
            expresion = null;
            error = null;
            try
            {
                expresion = ProcesarFuncion(latex);
                var testExp = new Expression(expresion, new Argument("x", 1.0));
                if (!testExp.checkSyntax())
                {
                    error = "La función es demasiado compleja o contiene símbolos no soportados.\n" +
                            "Intenta simplificarla o escríbela de forma diferente.";
                    expresion = null;
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                expresion = null;
                return false;
            }
        }

        public double Evaluar(string expresion, double x)
        {
            Argument argX = new Argument("x", x);
            Expression exp = new Expression(expresion, argX);
            double result = exp.calculate();

            if (double.IsNaN(result))
            {
                if (!exp.checkSyntax())
                    throw new Exception(
                        "La función es demasiado compleja o contiene símbolos no soportados.\n" +
                        "Intenta simplificarla o escríbela de forma diferente.");

                throw new Exception(
                    $"La función no está definida en x = {x}.\n" +
                    "Posible causa: logaritmo de negativo, raíz de negativo, tan(π/2), etc.");
            }

            if (double.IsInfinity(result))
                throw new Exception(
                    $"La función diverge en x = {x} (asíntota vertical o división por cero).");

            return result;
        }



        private string LimpiarComandosFormato(string expr)
        {
            expr = Regex.Replace(expr, @"\\left\s*", "");
            expr = Regex.Replace(expr, @"\\right\s*", "");
            expr = Regex.Replace(expr, @"\\mathrm\{([^}]*)\}", "$1");
            expr = Regex.Replace(expr, @"\\text\{([^}]*)\}", "$1");
            expr = expr.Replace(@"\cdot", "*");
            expr = expr.Replace(@"\times", "*");
            return expr;
        }
        private string ConvertirExponentes(string expr)
        {
            return Regex.Replace(expr, @"\^\{([^{}]*)\}", m =>
            {
                string contenido = m.Groups[1].Value;
                return Regex.IsMatch(contenido, @"^[a-zA-Z0-9]+$")
                    ? "^" + contenido
                    : "^(" + contenido + ")";
            });
        }

        private string ConvertirFracciones(string expr)
        {
            int maxPasos = 20;
            int paso = 0;
            while (expr.Contains(@"\frac") && paso++ < maxPasos)
                expr = Regex.Replace(expr, @"\\frac\{([^{}]+)\}\{([^{}]+)\}", "($1)/($2)");
            return expr;
        }

        private string ConvertirFunciones(string expr)
        {
            expr = expr.Replace(@"\arctan", "arctan");
            expr = expr.Replace(@"\arcsin", "arcsin");
            expr = expr.Replace(@"\arccos", "arccos");
            expr = expr.Replace(@"\sin", "sin");
            expr = expr.Replace(@"\cos", "cos");
            expr = expr.Replace(@"\tan", "tan");
            expr = expr.Replace(@"\sqrt", "sqrt");
            expr = expr.Replace(@"\ln", "ln");
            expr = expr.Replace(@"\log", "log10");
            expr = expr.Replace(@"\cot", "cot");
            expr = expr.Replace(@"\pi", "pi");
            expr = Regex.Replace(expr, @"\\e(?![a-zA-Z])", "e");
            return expr;
        }

        private string Limpiar(string expr)
        {
            expr = expr.Replace("{", "(");
            expr = expr.Replace("}", ")");
            expr = expr.Replace(" ", "");
            return expr;
        }

        private string AgregarMultiplicacionImplicita(string expr)
        {
            string[] funciones = {
                "arctan", "arcsin", "arccos",
                "log10", "sqrt", "exp", "abs",
                "sin", "cos", "tan", "cot", "ln", "log"
            };

            for (int i = 0; i < funciones.Length; i++)
                expr = expr.Replace(funciones[i], $"§{funciones[i]}§");
            expr = Regex.Replace(expr, @"(\d)(e)(?![0-9+\-])", "$1*$2");
            expr = Regex.Replace(expr, @"(\d)([a-df-zA-Z])", "$1*$2");
            expr = Regex.Replace(expr, @"([a-zA-Z])(\d)", "$1*$2");
            expr = Regex.Replace(expr, @"\)\(", ")*(");
            expr = Regex.Replace(expr, @"(\d)\(", "$1*(");
            expr = Regex.Replace(expr, @"\)([a-zA-Z])", ")*$1");

            for (int i = 0; i < funciones.Length; i++)
                expr = expr.Replace($"§{funciones[i]}§", funciones[i]);

            return expr;
        }
    }
}