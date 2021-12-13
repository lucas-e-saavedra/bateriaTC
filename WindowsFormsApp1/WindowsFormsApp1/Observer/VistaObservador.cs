using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Observer
{
    class WidgetBateria : Label, IObservadorBateria
    {
        public Bateria bateria { get; set; }
        public void actualizar()
        {
            Text = $"Conectado: {bateria.Conectado}\nCargando: {bateria.Cargando}\nCarga: {bateria.Carga}%\nTiempoRestante: {bateria.TiempoRestante} minutos\n";
        }
    }
}