﻿using System;

namespace ContaBancaria
{

    class ContaComum {

    	private int numero;
	private string titular;
	protected double equilibrio;

	public ContaComum() {
		numero = 0;
		titular = "N/A";
		equilibrio = 0.0;
	}

	public ContaComum(int numero, string titular, double equilibrio) {
		this.numero = numero;
		this.titular = titular;
		this.equilibrio = equilibrio;
	}

	public int Numero {
		get {return numero;}
		set {numero = value;}
	}

	public string Titular {
		get {return titular;}
		set {titular = value;}
	}

	public double Equilibrio {
		get {return equilibrio;}
		set {equilibrio = value;}
	}

	public void Retirar(double quantia) {
		Equilibrio -= quantia;
	}

	public void Depositar(double quantia) {
		Equilibrio += quantia;
	}
    }

    class ContaEmpresa:ContaComum {

    	private double limiteEmprestimo;

	public ContaEmpresa() {}

	public ContaEmpresa(int numero, string titular, double equilibrio, double limiteEmprestimo) : base(numero, titular, equilibrio) {
		this.limiteEmprestimo = limiteEmprestimo;
	}	

	public void Emprestimo(double quantia) {
		
		if (quantia<limiteEmprestimo)
			equilibrio += quantia;
		else Console.WriteLine("A quantia de emprestimo deve ser menor que o limite de emprestimo.");
	}
    }

    class SalvarConta: ContaComum {
    
	private double taxaJuros;

	public SalvarConta() {
		taxaJuros = 0.0;
	}
    	public SalvarConta(int numero, string titular, double equilibrio, double taxaJuros) : base(numero, titular, equilibrio){
		this.taxaJuros = taxaJuros;
	}

	public double TaxaJuros {
		get {return taxaJuros;}
		set {taxaJuros = value;}
	}

	public void AtualizaSaldo() {
		equilibrio += taxaJuros/100.0*equilibrio;
	}
    }

    class Program
    {
	static void Listar(ContaComum contaPessoal) {

		Console.WriteLine($"N. da conta: {contaPessoal.Numero} Titular: {contaPessoal.Titular} Saldo: R$ {contaPessoal.Equilibrio}");
	}

        static void Main(string[] args)
        {
            ContaComum contaPessoal = new ContaComum();

	    contaPessoal.Numero = 13;
	    contaPessoal.Titular = "Nicolas Matheus Ferreira";
	    contaPessoal.Equilibrio = 936.57;	   

	    ContaEmpresa contaCorporativa = new ContaEmpresa(021, "Renato Garçia 021 LTDA", 1000, 500);
	    Console.WriteLine($"N. da conta: {contaCorporativa.Numero} Titular: {contaCorporativa.Titular} Saldo: R$ {contaCorporativa.Equilibrio}");
	    contaCorporativa.Emprestimo(499);
	    Console.WriteLine($"N. da conta: {contaCorporativa.Numero} Titular: {contaCorporativa.Titular} Saldo: R$ {contaCorporativa.Equilibrio}");

	    SalvarConta salvarConta = new SalvarConta(021, "Renato Garçia 021 LTDA", 1000, 20.0);	    
	    salvarConta.AtualizaSaldo();
	    Console.WriteLine($"N. da conta: {salvarConta.Numero} Titular: {salvarConta.Titular} Saldo: R$ {salvarConta.Equilibrio}");

	    ContaComum acc = contaCorporativa;
	    Console.WriteLine(acc.Titular);

        }
    }
}
