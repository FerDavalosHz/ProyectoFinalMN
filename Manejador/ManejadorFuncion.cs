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
                throw new Exception("Función vacía");

            string expr = latex;
            expr = ConvertirFracciones(expr);
            expr = ConvertirFunciones(expr);
            expr = Limpiar(expr);
            expr = AgregarMultiplicacionImplicita(expr);
            return expr;
        }

        private string ConvertirFracciones(string expr)
        {
            while (expr.Contains(@"\frac"))
            {
                expr = Regex.Replace(expr, @"\\frac\{([^{}]+)\}\{([^{}]+)\}", "($1)/($2)");
            }
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
            expr = expr.Replace(@"\e", "e");

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
            string[] funciones = { "arctan", "arcsin", "arccos", "sin", "cos", "tan", "sqrt", "log10", "log", "ln", "cot", "exp", "abs" };
            for (int i = 0; i < funciones.Length; i++)
                expr = expr.Replace(funciones[i], $"§{i}§");
            expr = Regex.Replace(expr, @"(\d)([a-zA-Z])", "$1*$2");
            expr = Regex.Replace(expr, @"([a-zA-Z])(\d)", "$1*$2");
            expr = Regex.Replace(expr, @"\)\(", ")*(");
            expr = Regex.Replace(expr, @"(\d)\(", "$1*(");
            expr = Regex.Replace(expr, @"\)([a-zA-Z])", ")*$1");

  
            for (int i = 0; i < funciones.Length; i++)
                expr = expr.Replace($"§{i}§", funciones[i]);

            return expr;
        }

        public double Evaluar(string expresion, double x)
        {
            Argument argX = new Argument("x", x);
            Expression exp = new Expression(expresion, argX);

            double result = exp.calculate();

            if (double.IsNaN(result))
                throw new Exception($"La expresión no pudo evaluarse en x={x}. Revisa la función.");

            return result;
        }
    }
}