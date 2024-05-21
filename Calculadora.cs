namespace EspacioCalculadora;

public class Calculadora {
    private double Dato;

    public double Resultado {
        get => Dato;
    }
    public void Sumar (double Termino) {
        if (Dato == 0) {
            Dato = Termino;
        } else {
        Dato = Dato + Termino;
        }
    }
    public void Restar (double Termino) {
        if (Dato == 0) {
            Dato = Termino;
        } else {
        Dato = Dato - Termino;
        }
    }
    public void Multiplicar (double Termino) {
        if (Dato == 0) {
            Dato = Termino;
        } else {
        Dato = Dato * Termino;
        }
    }
    public void Dividir (double Termino) {
        if (Dato == 0) {
            Dato = Termino;
        } else {
        Dato = Dato / Termino;
        }
    }

    public void Limpiar () {
        Dato = 0;
    }
}