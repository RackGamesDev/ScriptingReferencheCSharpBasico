using System; // las bibliotecas de codigo que usa
namespace purebecicasc
{
    public class Program // clase principal, puede derivar de algo
    {
        //ENTEROS:
        sbyte numerico = 120;
        short numerin = 32767;
        int numerote = 9999;
        long hipernumero = 9999999;

        //DECIMALES:
        float decimales = 10.232453f;
        double mascedimales = 10.38605837234056;

        //SI O NO:
        bool siono = false;

        //TEXTO:
        char unaletra = 'A';
        string texto = "11holabuenas que tal";

        //ENUMERADOS:
        enum Persona {none, Sentada, Depie, Tumbada, Otra };//primero se crea un enumerado con none y el resto de sus estados
        Persona unaPersona = Persona.Depie;//luego se pueden crear variables de ese tipo, como persona y elegirles el estado
        //para cambiarlo durante el codigo seria (unaPersona = persona.Sentada;)
        Persona PonerseDepie()//tambien se puede usar en funciones, y tambien que requiera argumentos en el ()
        {
            return Persona.Depie;
        }

        //------------------------------------------------------------------------------------------

        int num1, num2, num3; //declara en la misma linea, pero no tienen nada que ver entre si
        //int[] nums; //tambien se puede usar un array

        const int num4 = -9; //constantes que no se pueden cambiar durante el codigo

        

        static void Main(string[] args)
        {
            Console.WriteLine("afasf");
            //TRANSFORMACION VARIABLES:
            string textico = "hola";
            textico = textico.ToUpper(); //lo pone en mayusculas, seria "HOLA"
            textico = textico.ToLower(); //lo pone en minusculas, seria "hola"
            string nombre = "elpepe";
            string apellido = "apedillilloçñ😊😊😘"; //no hay problema con caracteres raros indiferentes de c#
            textico = "Soy " + nombre + " " + apellido; //concadenacion de strings
            //textico.Length; //lo largo que sea el texto
            string textoRaro = "a\'a\"a\\a\0a\ba\fa\na\ra\ta\va"; //para poner cosas especiales se usa la \, se llama "secuencias de escape de cadena". por ejemplo la \n es enter o la \" es comillas, en internet se ven mas
            //textico.algo() hay varias cosas chulas

            int numerico = 1;
            textico = numerico.ToString();//convierte numeros en letras
            textico = "12";
            numerico = int.Parse(textico);//convierte de letras a numeros, tryparse es para saber si se puede hacer o no devolviendo bool
                                          //numerico.algo() hay varias cosas chulas

            bool buleanica = false;
            textico = buleanica.ToString();//tambien la convierte en letras "false" o "true"
                                           //buleanica.algo() hay varias cosas chulas

            var te = "texto";
            var nu = 12;
            var bo = true;
            var fl = 0.15;
            //las variables var no son de ningun tipo hasta que se les asigna algo
            //te = 132; y luego esto no se podria cambiar

            //----------------------------------------------------------------------------------------------------

            //int[] variosNumeros; declarar array basico
            int[] variosNumeros = new int[3] { 0, 1, 2 };//declarar array, habrian 3 espacios y luego es opcional especificarlos ya, se podria hacer despues y dejarlo sin los {}
            //los arrays sirven para almacenar varios datos en una sola variable, se pueden usar tambien otras variables y variables de clase, y empiezan a contar desde 0
            variosNumeros[0] = 4;
            numerico = variosNumeros.Length; //.length es cuantos datos tiene, luego no se puede cambiar
            for (int i = 0; i < variosNumeros.Length; i++)//un bucle para gestionar arrays
            {
                variosNumeros[i] = 2;
            }

            //----------------------------------------------------------------------------------------------------

            bool condicion = true;
            if (condicion)
            {
                // si la condicion se cumple pasa algo, no tiene por que ser bool, pueden pasar cosas como en la seccion de abajo pero siempre tiene que terminar siendo como bool
            }
            else if (buleanica)
            {
                //si no es, va a la siguiente condicion
            }
            else
            {
                //si no es ninguna, usa el else
            }

            switch (numerico)//como el if pero mas extenso, comprueba los estados de una variable y ejecuta un codigo en cada caso, tambien vale con texto
            {
                case 0:
                    //si es 0 pasa esto
                    break;//break para cambiar
                case 1:
                    //si es 1 pasa esto
                    break;
                case 2:
                    //si es 2 pasa esto
                    break;
                case 3:
                    //si es 3 pasa esto
                    break;
                default:
                    //si no es ninguna pasa esto
                    break;
            }


            for (int i = 0; i < 10; i++)//bucle que se repite hasta que la variable llegue a un numero     int i = 0 es desde donte empieza, i < 10 parara si eso es verdad y 10 serian las repeticiones, i++ es cuanto suma
            {
                //esto se repetiria 10 veces
                Console.WriteLine(i);
            }

            do //primero ejecuta el codigo una vez, y luego se repite hasta que se cumpla la condicion del while
            {
                numerico++;
                Console.WriteLine(numerico);
            } while (numerico < 6);

            while (numerico < 15) //se repite hasta que se cumpla la condicion, cuidado que puede crashear
            {
                numerico++;
                Console.WriteLine(numerico);
                break;//si quieres salir por algo usas break, tambien sirve con ifs, otros bucles, switch y cualquier cosa con corchetes{}
                continue;//continue corta la vuelta del loop y lo lee otra vez
            }

            //----------------------------------------------------------------------------------------------------

            int sumaM = 1 + 2;
            int restaM = 1 - 2;
            int multiplicacionM = 2 * 2;
            int divisionDecimalM = 1 / 2;
            int divisionElRestoM = 1 % 3; //el resto de la division
            float raizCuadrada = MathF.Sqrt(25); //raiz cuadrada
            sumaM = Math.Clamp(sumaM, 0, 100); //le pone limites a un numero
            //mas funciones matematicas con MathF.algo()

            bool nohay = !buleanica; //lo contrario de algo con !
            sumaM++; //sumar 1, con -- se restaria, si se pone antes sirve para esa misma linea
            sumaM += 2; //lo que tiene mas lo que se le especifique, tamgien sirve con -=
            buleanica = textico.Equals("tacataca"); //devuelve bool desde cualquier variable, funciona como ==, normalmente va con strings
            buleanica = sumaM > restaM; //el mayor o menor que, seria true
            buleanica = sumaM == restaM; //si es igual que, seria false
            buleanica = sumaM != restaM; //si no es igual que, seria true
                                         //para que varias se cumplen en una condicional es && (shift 6)
                                         //para que alguna se cumple en una condicional es || (altgr 1)        

            //----------------------------------------------------------------------------------------------------

            try
            {
                //ejecuta el codigo de aqui dentro
            }
            catch (OverflowException) // y si da error (se puede especificar) cualquier error es con Exception
            {
                //ejecuta el de aqui, ignorando el otro error
            }
            catch (FormatException)
            {
                //si da el otro error
            }

            //---------------------------------------------------------------------------------------------------------

            int numeroResultadoFuncion = 0;
            numeroResultadoFuncion = FuncionConNumeros(12, 45); //tambien llamandola con sus argumentos, siempre aplicara un valor a una variable, el numero seria 57
            string letrasResultadoFuncion;
            letrasResultadoFuncion = FuncionConLetras("el", "pepe");//otro ejemplo con string

            FuncionPublica();//llamando a la variable
            FuncionPrivada();
            PasarVariable("Muy holas", 123);//llamando a la variable con sus argumentos

            //-----------------------------------------------------------------------------------------------------------

            Objeto cosa = new Objeto("cosa", 10, true);//declarando la variable apartir de la clase, en el caso que se haya un constructor, hay que especificar las propiedades
            cosa.Desactivar();
            cosa.nombre = "cosilla";
            cosa.Danarse(3);

            OtroObjeto cosica = new OtroObjeto();//declarando la otra variable de clase
            cosica.PonerAlto(4);
            cosica.PonerLargo(8);
            cosica.PonerAncho(3);
            cosica.RecalcularVolumen();


            //-----------------------------------------------------------------------------------------------------------


            Console.Read();
        }
        
        public static void FuncionPublica()
        {
            Console.WriteLine("funcion publica");
            //una funcion que puede ser llamada desde otras clases, con el PUBLIC, debe ser static para poder ser llamado desde Main()
        }
        private static void FuncionPrivada()
        {
            Console.WriteLine("funcion privada");
            //una funcion que solo puede ser llamada desde esta clase, con el PRIVATE, debe ser static para poder ser llamado desde Main()
        }
        public static void PasarVariable(string pasarTexto, int pasarNumero)
        {
            Console.WriteLine(pasarTexto + pasarNumero.ToString());
            //una funcion que necesita unas variables al ser llamada, que usara durante su codigo
        }

        public static int FuncionConNumeros(int numer1, int numer2)
        {
            return numer1 + numer2;//lo que devolvera a la variable desde la que se llamo, pueden haber varios casos con varios return
                                   //una funcion que se basa en un tipo de variable, necesita si o si argumentos y un return
        }
        public static string FuncionConLetras(string palabra1, string palabra2)
        {
            return palabra1 + palabra2;
            //otro ejemplo con string
        }
    }

    class Objeto//haciendo otra clase, se crea un nuevo tipo de variable con las propiedades y funciones de dentro de la clase
    {
        public string nombre;
        public int vida;
        public bool activo;

        public Objeto(string minombre, int mivida, bool miactivo)//el constructor, especifica las variables que hay que especificar a la hora de crear una de estas variables
        {
            nombre = minombre;
            vida = mivida;
            activo = miactivo;
        }

        public void Desactivar()//para que las funciones se puedan usar desde esa variable, tienen que ser publicas
        {
            activo = false;
        }
        public void Danarse(int cuanto)
        {
            vida -= cuanto;
        }
    }

    class OtroObjeto //otra clase, por lo tanto, otra variable con sus propiedades y funciones
    {
        private int largo;
        private int ancho;
        private int alto;
        public int volumen;

        public int Largo { get; set; }

        public void RecalcularVolumen()
        {
            volumen = largo * ancho * alto;
            Console.WriteLine(largo + " " + ancho + " " + alto + " " + volumen);
        }

        public void PonerLargo(int largo)
        {
            this.largo = largo;
        }
        public void PonerAlto(int alto)
        {
            this.alto = alto;
        }
        public void PonerAncho(int ancho)
        {
            this.ancho = ancho;
        }

        public int PillarLargo()
        {
            return this.largo;
        }
        public int PillarAncho()
        {
            return this.ancho;
        }
        public int PillarAlto()
        {
            return this.alto;
        }
    }
}

