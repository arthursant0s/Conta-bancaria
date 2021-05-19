﻿using System;
using System.Globalization;

namespace Curso
{
    class ContaBancaria

    {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoinicial) : this (numero, titular)
        {
            Deposito(depositoinicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero 
                + ", Titular: "
                + Titular 
                + ", Saldo: $ " +
                " " + Saldo.ToString("F2", CI);
         

        }

    }

    }
