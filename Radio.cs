namespace Gaspar{
    public class Radio:Dispositivo{
        public bool bandaAm;
        public bool bandaFm;
        public bool esSatelital;

        public Radio(string codigo, string pais, bool am, bool fm, bool satelital){
            this.codigo = codigo;
            this.paisFabricacion = pais;
            this.bandaFm = fm;
            this.bandaAm = am;
            this.esSatelital = satelital;
            activo = false;
        }

          public override void printInfo(){
            Console.WriteLine($@"RADIOS
            Codigo: {codigo}
              funciona am: {bandaAm}
              funciona fm:    {bandaFm}
              Es Satelital:  {esSatelital}
            fecha Construccion:  {fechaConstruccion}
            fecha Destruccion:   {fechaDestruccion}
            pais de fabricacion: {paisFabricacion}
            esta activo:         {activo}
            -----------------------------------------");
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