using System;

namespace Ejer.Cap10_Y_12
{
    class Ejercicio10_3_4_5
    {
        private int Lados;
        private int Distancia;

        public int lados
        {
            get{ return Lados;}
            set{
                if (value >= 3)
                    Lados = value;
                else
                    Lados = 0;
            }
        }

        public int distancia
        {
            get{return Distancia;}
            set
            {
                if (value > 0)
                    Distancia = value;
                else
                    Distancia = 0;
            }
        }
        public Ejercicio10_3_4_5()
        {
            Lados = 0;
            Distancia = 0;
        }

        public Ejercicio10_3_4_5(int lados, int distancia)
        {
            Lados = lados;
            Distancia = distancia;
        }

        public override string ToString()
        {
            String mensaje = "";
            mensaje += "Los lados del poligono son " + Lados.ToString() +
                        " y su distancia es " + Distancia.ToString();
            return mensaje;
        }


    }
}