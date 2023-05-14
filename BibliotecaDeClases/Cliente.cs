using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum eMetodoPago
    {
        Efectivo,
        Tarjeta_de_credito,
        Mercado_pago,
        Tarjeta_de_debito
    }
    public class Cliente : Usuario
    {
        //atributos
        private string nombre;
        private float montoDisponible;
        private eMetodoPago metodoPago;
        //constructor
        public Cliente(string nombre,string mail, string password, float montoDisponible,eMetodoPago metodoPago)
        : base(mail, password)
        {
            this.nombre = nombre;
            this.montoDisponible = montoDisponible;
            this.metodoPago = metodoPago;
        }
        //propiedad
        public string GetNombre
        { 
            get { return nombre; }
        }
        public string SetNombe
        {
            set { this.nombre = value; }
        }
        public float GetMontoDisponible
        {
            get { return montoDisponible; }
        }
        public float SetMontoDisponible
        {
            set
            {
                if (montoDisponible > 0)
                {
                    this.montoDisponible = value;
                }
                else 
                {
                    this.montoDisponible = 0;
                }
            }
        }
        public eMetodoPago GetMetodoPago
        {
            get { return this.metodoPago; } 
        }
        //metodo
        /// <summary>
        /// valida el valor q ingreso el cliente
        /// </summary>
        /// <param name="valorAValidar">celda del data grid view a validar</param>
        /// <returns>retorna el valor en flotante si es un numero y 0 si era una letra</returns>
        public static float ObtenerCeldaAValidar(object valorAValidar)
        {
            float valorFloat;
            if (valorAValidar != null && float.TryParse(valorAValidar.ToString(), out valorFloat))
            {
                return valorFloat;
            }
            return 0.0f;//valor predeterminado por si no puede convertir 
        }
    }
}
