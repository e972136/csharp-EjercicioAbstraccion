namespace Gaspar{
public abstract class Dispositivo{
    public string ?codigo{set;get;}
    public string ?fechaConstruccion{set;get;}
    public string ?fechaDestruccion{set;get;}
    public string ?paisFabricacion{set;get;}
    public bool ?activo{set;get;}

    public abstract void printInfo();

    public abstract void activarDispositivo(string fecha);

    public abstract void destruirDispositivo(string fecha);


}
}

