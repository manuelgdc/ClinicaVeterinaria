using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANIMALES
{
    abstract class Animal
    {

        //ATRIBUTOS
        protected string nombre;
        protected DateTime fechaNacimiento;
        protected double peso;
        protected string comentarios;

        //PROPIEDADES
        /// <summary>
        /// 
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }
            set
            {
                if (value > 0)
                {
                    value = peso;
                }
                else
                {
                    throw new Exception("error");
                }
            }
        }


        public string Comentarios
        {
            get
            {
                return comentarios;
            }
            set
            {
                comentarios = value;
            }
        }

        //METODO ABSTRACTO
        /// <summary>
        /// metodo para obligar a que las clases que heredan de Animal implementen obligatoriamente el ToString()
        /// </summary>
        /// <returns></returns>
        public override abstract string ToString();
    }



    enum RazaPerro
    {
        PastorAleman, Husky, FoxTerrier, Dalmata, SanBernardo
    }


    //clase perro(hereda de animal)

    class Perro : Animal
    {

        //ATRIBUTOS
        private RazaPerro raza;
        private string microchip;

        //PROPIEDADES DE SOLO LECTURA
        public RazaPerro Raza
        {
            get { return raza; }
        }

        public string Microchip
        {
            get { return microchip; }
        }

        //CONSTRUCTOR
        public Perro(string Nombre, DateTime FechaNacimiento, double Peso, string Microchip, RazaPerro Raza)
        {
            this.nombre = Nombre;
            this.fechaNacimiento = FechaNacimiento;
            this.peso = Peso;
            this.microchip = Microchip;
            this.raza = Raza;
        }

        /// <summary>
        /// Método que sobreescribe al abstracto que servirá para mostrar por pantalla una ficha con todos los atributos de perro
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ficha = "";
            ficha = "Ficha de Perro\n" + "".PadLeft(80, '-') + "\n Nombre: " + this.nombre + "\n Raza: " + this.raza + "\n Fecha de Nacimiento: " + this.fechaNacimiento + "\n Peso: " + this.peso + " kg \n Microchip: " + microchip + "\n Comentarios: " + comentarios + "\n" + "".PadLeft(80, '-');
            return ficha;
        }
    }


    enum RazaGato
    {
        Comun, Siames, Persa, Angora, ScottishFold
    }

    //clase gato(hereda de animal)

    class Gato : Animal
    {
        //ATRIBUTOS

        private RazaGato raza;
        private string microchip;


        //CONSTRUCTOR
        public Gato(string Nombre, RazaGato Raza, DateTime FechaNacimiento, double Peso, string Microchip)
        {
            this.nombre = Nombre;
            this.raza = Raza;
            this.fechaNacimiento = FechaNacimiento;
            this.peso = Peso;
            this.microchip = Microchip;
        }

        //PROPIEDADES
        public RazaGato Raza
        {
            get
            {
                return raza;
            }
        }

        public string Microchip
        {
            get
            {
                return microchip;
            }
        }

        public override string ToString()
        {
            string ficha = "";

            ficha = "Ficha de Gato\n" + "".PadLeft(80, '-') + " \n Nombre: " + this.nombre + "\n Raza: " + this.raza + "\n Fecha de Nacimiento: " + this.FechaNacimiento + "\n Peso: " + this.peso + " kg \n Microchip: " + microchip + "\n Comentarios: " + comentarios + "\n" + "".PadLeft(80, '-');
            return ficha;
        }
    }



    enum EspeciePajaro
    {
        Canario, Periquito, Agapornis
    }

    //clase pajaro(hereda de animal)

    class Pajaro : Animal
    {

        //atributos
        private EspeciePajaro especie;
        private bool cantor;

        //constructor
        public Pajaro(string Nombre, EspeciePajaro Especie, DateTime FechaNacimiento, double Peso, bool Cantor)
        {
            this.nombre = Nombre;
            this.especie = Especie;
            this.fechaNacimiento = FechaNacimiento;
            this.peso = Peso;
            this.cantor = Cantor;
        }

        //propiedades
        public EspeciePajaro Especie
        {
            get
            {
                return especie;
            }
        }

        public bool Cantor
        {
            get
            {
                return cantor;
            }
        }
        //metodo
        public override string ToString()
        {
            string ficha = "";

            ficha = "Ficha de Pajaro\n" + "".PadLeft(80, '-') + " \n Nombre: " + this.nombre + "\n Especie: " + this.especie + "\n Fecha de Nacimiento: " + this.fechaNacimiento + "\n Peso: " + this.peso + " kg \n Cantor: " + cantor + "\n Comentarios: " + comentarios + "\n" + "".PadLeft(80, '-');
            return ficha;
        }
     }


    enum EspecieReptil
    {
        Tortuga, Iguana, DragonDeComodo
    }

    //clase Reptil(hereda de animal)

        class Reptil: Animal
    {

        //atributos
        private EspecieReptil especie;
        private bool venenoso;

        //constructor
        public Reptil(string Nombre, EspecieReptil Especie, DateTime FechaNacimiento, double Peso, bool Venenoso)
        {
            this.nombre = Nombre;
            this.especie = Especie;
            this.fechaNacimiento = FechaNacimiento;
            this.peso = Peso;
            this.venenoso = Venenoso;
        }
        //propiedades
        public EspecieReptil Especie
        {
            get
            {
                return especie;
            }
        }

        public bool Venenoso
        {
            get
            {
                return venenoso;
            }
        }

        //metodo
        public override string ToString()
        {
            string ficha = "";

            ficha = "Ficha de Reptil\n" + "".PadLeft(80, '-') + " \n Nombre: " + this.nombre + "\n Especie: " + this.especie + "\n Fecha de Nacimiento: " + this.fechaNacimiento + "\n Peso: " + this.peso + " kg \n Venenoso: " + venenoso + "\n Comentarios: " + comentarios + "\n" + "".PadLeft(80, '-');
            return ficha;
        }
    }



    class Clinica
    {
        //atributos
        private List<Animal> ListaAnimales;

        //constructor
        /// <summary>
        /// inicializa la lista
        /// </summary>
        public Clinica()
        {
            ListaAnimales = new List<Animal>();
        }
        //metodos
        /// <summary>
        /// le pasamos un animales y lo anade a la lista
        /// </summary>
        /// <param name="animmal"></param>
        public void InsertaAnimal(Animal animmal)
        {
            ListaAnimales.Add(animmal);
        }

        /// <summary>
        /// le pasamos el nombre del animal y nos devuelve el animal en cuestion
        /// </summary>
        /// <param name="nombre"></param>
        public Animal BuscaAnimal(string nombre)
        {
            Animal buscado = null;
            for(int i=0; i<ListaAnimales.Count; i++)
            {
                if (ListaAnimales[i].Nombre == nombre)
                {
                    ListaAnimales[i] = buscado;
                }

            }
            return buscado;
        }

        /// <summary>
        /// nos modifica la lista de todas las fichas de los animales
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="comentario"></param>
        public void ModificaComentarioAnimal(string nombre, string comentario)
        {
            for( int i=0; i<ListaAnimales.Count; i++)
            {
                if(ListaAnimales[i].Nombre==nombre)
                {
                    ListaAnimales[i].Comentarios = comentario;
                }
            }
        }

        /// <summary>
        /// muestra la lista de todas las fichas de los animales
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cadena="";
            for (int i=0; i<ListaAnimales.Count; i++)
            {
                 cadena = cadena + ListaAnimales[i] + " \n ";
            }

            return cadena;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            bool pregunta = false;
            bool pregunta2 = true;
            int eleccion;

            Console.WriteLine("bienvenido a la clinica veterinaria");
            Console.WriteLine("desea introducir un nuevo animal? (true o false)");
            pregunta = bool.Parse(Console.ReadLine());
            if (pregunta == true)
            {
                while(pregunta2==true)
                {
                   

                    DateTime d = new DateTime(2016, 05, 06);
                    Perro perro1 = new Perro("rocky", d, 50, "5142as", RazaPerro.Husky);

                    Clinica clinica = new Clinica();
                    clinica.InsertaAnimal(perro1);

                    Console.WriteLine("que tipo de animal desea introducir\n Perro:1\n Gato:2\n Pajaro:3\n Reptil:4\n");
                    eleccion = int.Parse(Console.ReadLine());
                    switch(eleccion)
                    {
                        case 1:
                            {
                                Console.WriteLine("introduce el nombre: ");
                                string nombre = Console.ReadLine();
                                Console.WriteLine("Introduce la raza\n PastorAleman-> 1\n Husky-> 2\n FoxTerrier->3\n Dalmata->4\n SanBernardo-> 5");
                                RazaPerro rperro = (RazaPerro)(int.Parse(Console.ReadLine()) - 1);
                                Console.WriteLine("introduce la fecha de nacimiento");
                                DateTime fecha = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("introduce el peso");
                                double kilos = double.Parse(Console.ReadLine());
                                Console.WriteLine("introduce el microchip");
                                string microchip = Console.ReadLine();
                                Perro nuevo = new Perro(nombre, fecha, kilos, microchip, rperro);
                                clinica.InsertaAnimal(nuevo);
                                Console.WriteLine("escriba un comentario si lo desea: ");
                                string comentario = Console.ReadLine();
                                clinica.ModificaComentarioAnimal(nombre, comentario);

                                break;
                            }
                        case 2:
                            {

                                break;
                            }
                        default:
                            break;

                    }
                    Console.WriteLine("desea introducir otro animal? (true or false)");
                    pregunta2 = bool.Parse(Console.ReadLine());
                }
            }




        }
    }
}
