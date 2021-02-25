using System;
using System.Collections.Generic;
using System.Text;

namespace Visor
{

    class Cuenta
    {
        private int numCuenta;
        private String titular;
        private String fechaApertura;
        private double saldo;
        private String nacionalidad;

        public Cuenta()
        {
            this.numCuenta = 0;
            this.titular = "";
            this.fechaApertura = "";
            this.saldo = 0;
            this.nacionalidad = "";
        }

        public int getNumCuenta() 
        {
            return numCuenta;
        }

        public void setNumCuenta(int numCuenta)
        {
            this.numCuenta = numCuenta;
        }

        public String getTitular()
        {
            return titular;
        }

        public void setTitular(String titular)
        {
            this.titular = titular;
        }

        public String getFechaApertura()
        {
            return fechaApertura;
        }

        public void setFechaApertura(String fechaApertura)
        {
            this.fechaApertura = fechaApertura;
        }

        public double getSaldo()
        {
            return saldo;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public String getNacionalidad()
        {
            return nacionalidad;
        }

        public void setNacionalidad(String nacionalidad)
        {
            this.nacionalidad = nacionalidad;
        }
    }
}
