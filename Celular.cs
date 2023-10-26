namespace Gaspar{
    public class Celular:Dispositivo{

        public string modelo;
        public string redTelefonia;
        public string bandaTelefonia;

        public override void printInfo(){
            Console.WriteLine($@"CELULAR
            Codigo: {codigo}
              modelo: {modelo}
              red:    {redTelefonia}
              banda:  {bandaTelefonia}
            fecha Construccion:  {fechaConstruccion}
            fecha Destruccion:   {fechaDestruccion}
            pais de fabricacion: {paisFabricacion}
            esta activo:         {activo}
            -----------------------------------------");
        }

        public Celular(string codigo, string pais, string modelo, string redTelefonia, string bandaTelefonia){
            this.codigo = codigo;
            this.paisFabricacion = pais;
            this.modelo = modelo;
            this.redTelefonia = redTelefonia;
            this.bandaTelefonia = bandaTelefonia;
            activo = false;
        }

        public override void activarDispositivo(string fecha){
            activo = true;
            fechaConstruccion = fecha;
        }
        public override void destruirDispositivo(string fecha){
            activo = false;
            fechaDestruccion = fecha;
        }
    }
}