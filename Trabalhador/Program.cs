using System;

namespace Trabalhador
{
    class ContratoHora {

        public DateTime data {get; set;}
        public double valorPorHora {get; set;}
        public int horas {get; set;}
        public ContratoHora() {}
        public ContratoHora(DateTime data, double valorPorHora, int horas) {
            this.data = data;
            this.valorPorHora = valorPorHora;
            this.horas = horas;
        }        

        public double valorTotalContrato() { 
            return valorPorHora*horas;
        }
    }
    class Departamento {
        public string nome {get; set; }

        public Departamento(string nome) {}
        public Departamento(string nome) {
            this.nome = nome;
        }        
    }
    class Trabalhador {
        
        public string nome {get; set;}
        public double salarioBase {get; set;}

        public Trabalhador() {}
        public Trabalhador(string nome, double salarioBase, Departamento departamento) {
            this.nome = nome;
            this.salarioBase = salarioBase;
            this.departamento = departamento;
        }

        public Departamento departamento {get; set;}
        public List<ContratoHora> contratos {get; set;}

        public void AddContrato(ContratoHora contrato) {
            contratos.Add(contrato);
        }

        public void RemoveContrato(ContratoHora contrato) {
            contratos.Remove(contrato);
        }

        public double Soma(int ano, int mes) {
            double soma = salarioBase;
            foreach(ContratoHora contrato in contratos) {
                if (contrato.data.Date.Year==ano && contrato.data.Date.Month==mes) {
                    soma = soma + contrato.valorTotalContrato();
                }
            }
            return soma;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
