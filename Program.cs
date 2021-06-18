using System;

namespace dev_homework06
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("\n");
            Console.WriteLine("Hola buenos dias bienvenido a la distribuidora de autos RODRIGUEZ");
            Console.WriteLine("\n");
            Console.WriteLine("Comenzaremos con el proceso para la compra de su auto");
            Console.WriteLine("\n");
            Console.WriteLine("Que modelo quiesera, ¿AudiA3 o BMWSerie1?");
            var auto = Console.ReadLine();
            Console.WriteLine("De que color quiere su automovil, ¿blanco o negro?");
            var color = Console.ReadLine();
            Console.WriteLine("De que color quiere sus interiores, ¿rojos o negros?");
            var color1 = Console.ReadLine();
            Console.WriteLine("como quiere su transmision, ¿manual o automatico?");
            var transmision = Console.ReadLine();
            string[] carro = new string[4];
            
            if(auto == "AudiA3"){
                carro[0] = "AudiA3";
            }
            else if(auto == "BMWSerie1"){
                carro[0] = "BMWSerie1";
            }

            if(color == "blanco"){
                carro[1] = "blanco";
            }
            else if(color == "negro"){
                carro[1] = "negro";
            }

            if(color1 == "rojos"){
                carro[2] = "rojos";
            }
            else if(color1 == "negro"){
                carro[2] = "negro";
            }

            if(transmision == "manual"){
                carro[3] = "manual";
            }
            else if(transmision == "automatico"){
                carro[3] = "automatico";
            }

            Console.WriteLine("\n");
            Console.WriteLine("¡Listo! A terminado de configurar su carro");
            Console.WriteLine("Aqui abajo esta su recibo");

            /*
            for(int i=0; i<4; i++){
                if(!string.IsNullOrEmpty(carro[i]))
                Console.WriteLine(carro[i]);
            }

            este for ya no lo ocupe porque solo sacaba las opciones seleccionadas, no lo 
            sacaba con el nombre que que queria, por ejemplo queria que dijera: Modelo: 
            AudiA3 y con el for solo sacaba AudiA3
            */

            Console.WriteLine("\n");
            Console.WriteLine($"Modelo: {carro[0]} ");
            Console.WriteLine($"Color: {carro[1]} ");
            Console.WriteLine($"Color interiores: {carro[2]} ");
            Console.WriteLine($"Transmision: {carro[3]} ");
            Console.WriteLine("\n");
        }
    }
}
