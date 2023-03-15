using System;

public class Fila {

    Celula inicio, fim;
    public Fila() {
        inicio = null;
        inicio = new Celula();    
        fim = inicio;        
    }

    public void Inserir(int x) {
        Elemento elemento = new Elemento(x);                
        fim.atual = elemento;
        fim = fim.proximo;            
    }

    public void Listar() {
        Celula aux = inicio;
        if (aux==null)
            Console.WriteLine("Fila vazia!");
        else {
                while(aux!=null) {
                    Console.WriteLine(aux.atual.Valor);
                    aux = aux.proximo;
                }
        }
    }
}