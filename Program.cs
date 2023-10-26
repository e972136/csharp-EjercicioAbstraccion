using Gaspar;
Console.WriteLine("Generacion dispositivo celular");
Celular celular = new Celular("1h","Honduras","Nokia","Claro","4g");
celular.activarDispositivo("2022-10-15");
celular.printInfo();
celular.destruirDispositivo("2022-12-15");
celular.printInfo();

Console.WriteLine("Generacion dispositivo radio");
Radio radio = new Radio("2h","Honduras",false,true,true);
radio.activarDispositivo("2022-10-15");
radio.printInfo();
radio.destruirDispositivo("2022-12-15");
radio.printInfo();
