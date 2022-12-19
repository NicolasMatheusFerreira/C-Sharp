using System;

public class Pilha {

    Celula inicio;
    public Pilha() {
        inicio = null;
    }

    public void Inserir(int x) {
        Elemento elemento = new Elemento(x);

        if (inicio==null) {
            inicio = new Celula();
            inicio.atual = elemento;            
        } else {
            Celula i = new Celula();
            i.atual = elemento;
            i.proximo = inicio;
            inicio = i;
        }
    }
    public Elemento Remover() {
        if (inicio!=null) {
            Celula aux = inicio;        
            Elemento i = new Elemento(aux.atual.Valor);
            inicio = aux.proximo;
            return i;
        }
        return null;
    }
    public void Listar() {

        Celula aux = inicio;
        if (aux!=null)
           while(aux!=null) {
                Console.Write(aux.atual.Valor+" ");
                aux = aux.proximo;
            }
        else Console.WriteLine("Pilha vazia!");
    }
}