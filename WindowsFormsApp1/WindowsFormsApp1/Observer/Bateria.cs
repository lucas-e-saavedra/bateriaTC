using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Observer
{
    public class Bateria
    {
        public bool Conectado { get; set; }
        public bool Cargando { get; set; }
        public int Carga { get; set; }
        public int TiempoRestante { get; set; }
        
        public void Cargar() {
            if (Carga < 100)
                Carga++;
            Conectado = true;
            Cargando = true;
            TiempoRestante = Carga * 3;
            Notifica();
        }
        public void ConsumirEnergia() {
            if (Carga > 0)
                Carga--;
            Conectado = false;
            Cargando = false; 
            TiempoRestante = Carga * 3;
            Notifica();
        }

        public Bateria()
        {
            observadores = new List<IObservadorBateria>();
        }
        private List<IObservadorBateria> observadores;

        public void Suscribirse(IObservadorBateria unObservador) {
            observadores.Add(unObservador);
        }
        public void Desuscribirse(IObservadorBateria unObservador) {
            observadores.Remove(unObservador);
        }
        void Notifica() {
            observadores.ForEach( item => item.actualizar());
        }
    }
}
