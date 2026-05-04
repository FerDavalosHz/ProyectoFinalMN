using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Manejador
{
    public class ManejadorQIA
    {
        private readonly string apiKey = Environment.GetEnvironmentVariable("GROQ_API_KEY");
        private readonly string url = "https://api.groq.com/openai/v1/chat/completions";

        public async Task GenerarProblemaPro(
            RichTextBox richBox,
            string funcion,
            string metodo,
            string parametros)
        {
            try
            {
                string prompt = $@"
Genera un problema corto de métodos numéricos aplicado a computación.

Método: {metodo}
Función: {funcion}
Parámetros: {parametros}

Formato:
- Un solo párrafo
- Máximo 5 líneas
- Lenguaje sencillo

Debe:
- Empezar con 'En una empresa de...' o similar
- Incluir qué representa la función
- Incluir el intervalo o datos
- Decir qué se desea calcular
- Explicar brevemente por qué conviene usar el método {metodo}

Restricciones:
- NO listas
- NO formato académico
- NO símbolos raros
- NO resolver
- NO dar resultados
";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                    var body = new
                    {
                        model = "llama-3.1-8b-instant",
                        temperature = 0.8,
                        messages = new[]
                        {
                            new { role = "user", content = prompt }
                        }
                    };

                    var json = JsonConvert.SerializeObject(body);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);
                    var result = await response.Content.ReadAsStringAsync();

                    if (!response.IsSuccessStatusCode)
                    {
                        MostrarError(richBox, $"Error HTTP: {response.StatusCode}\n{result}");
                        return;
                    }

                    dynamic data = JsonConvert.DeserializeObject(result);

                    if (data == null || data.choices == null)
                    {
                        MostrarError(richBox, "Respuesta inválida:\n" + result);
                        return;
                    }

                    string texto = data.choices[0]?.message?.content;

                    if (string.IsNullOrEmpty(texto))
                    {
                        MostrarError(richBox, "Sin contenido:\n" + result);
                        return;
                    }

                    MostrarProblemaFormateado(richBox, texto, metodo);
                }
            }
            catch (Exception ex)
            {
                MostrarError(richBox, "Error IA: " + ex.Message);
            }
        }


        private void MostrarProblemaFormateado(RichTextBox richBox, string texto, string metodo)
        {
            richBox.Clear();

       
            richBox.SelectionFont = new Font("Segoe UI", 13, FontStyle.Bold);
            richBox.SelectionColor = Color.DarkBlue;
            richBox.AppendText("Problema generado\n");

      
            richBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richBox.SelectionColor = Color.Gray;
            richBox.AppendText("────────────────────────────\n\n");

            richBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Bold);
            richBox.SelectionColor = Color.Black;
            richBox.AppendText("Método: " + metodo + "\n\n");


            richBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richBox.SelectionColor = Color.Black;

            richBox.AppendText(texto);
        }

     
        private void MostrarError(RichTextBox richBox, string mensaje)
        {
            richBox.Clear();

            richBox.SelectionFont = new Font("Segoe UI", 11, FontStyle.Bold);
            richBox.SelectionColor = Color.Red;
            richBox.AppendText("Error\n\n");

            richBox.SelectionFont = new Font("Segoe UI", 10, FontStyle.Regular);
            richBox.AppendText(mensaje);
        }
    }
}