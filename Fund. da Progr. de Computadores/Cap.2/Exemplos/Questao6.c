#include <stdio.h>
#include <ctype.h>

int main(void) {
		int qtd_func = 1, codigo, hrs_trab_mes=0, i = 1;
		char turno_trabalho, categoria;
		double salario_minimo = 450, salario_inicial = 0, aux_aliment=0, percent=0, valor_hora_trab=0;

		while(i<=qtd_func) {
			printf("Informe o codigo do funcionario: ");
			scanf("%d", &codigo);

			printf("Informe as horas trabalhadas no mes: ");
			scanf("%d", &hrs_trab_mes);

			printf("Informe o turno de trabalho:");
			setbuf(stdin, NULL);
			scanf(" %c", &turno_trabalho);

			turno_trabalho = toupper(turno_trabalho);


			if (turno_trabalho=='N' || turno_trabalho=='V' || turno_trabalho=='M') {
				printf("Informe a categoria do funcionario: ");
				setbuf(stdin, NULL);
				scanf(" %c", &categoria);
				categoria = toupper(categoria);

				if (categoria=='O' || categoria=='G') {
					if (categoria=='G' && turno_trabalho=='N') {
						valor_hora_trab = salario_minimo*18/100;
					} else if (turno_trabalho=='G' && (turno_trabalho=='M' || turno_trabalho=='V')) {
						valor_hora_trab = salario_minimo*15/100;
					} else if (categoria=='O' && turno_trabalho=='N') {
						valor_hora_trab = salario_minimo*13/100;
					} else if (categoria=='O' && (turno_trabalho=='M' || turno_trabalho=='V')) {
						valor_hora_trab = salario_minimo*10/100;
					}
				} else printf("\aCategoria invalida!");
			} else printf("\aTurno de trabalho invalido!");

			salario_inicial = valor_hora_trab*hrs_trab_mes;

			if (salario_inicial<300) {
				percent = 0.20;
			} else if (salario_inicial>=300 && salario_inicial<=600) {
				percent = 0.15;
			} else percent = 0.05;

			aux_aliment = percent*salario_inicial;

			printf("Funcionario %d - Qtd. de horas trab. %d - Valor da hora trab. R$ %.2f - Salario Inic. %.2f - Aux. Alim. %.2f - Salario final R$ %.2f", codigo, hrs_trab_mes, valor_hora_trab, salario_inicial, aux_aliment, (salario_inicial+aux_aliment));		
			i++;
		}
	
	return 0;
}
