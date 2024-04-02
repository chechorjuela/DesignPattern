namespace Singleton.Singleton
{
    public class MySingleton
    {

        //Esta variable debe ser privada y estatica. y como va a ser global se coloca un raya al piso
        private static MySingleton _instance;

        public Guid id;

        // El constructor debe ser priado el constructor
        private MySingleton()
        {
            id = Guid.NewGuid();
        }

        // se agrega un metodo la cual es la proporcionada de crear instancias.
        // debe ser public y estatico para devolver la instancia ya creada si no existe
        // crearla.
        public static MySingleton GetInstance()
        {
            if (_instance == null)
            {

                _instance = new MySingleton();

            }
            return _instance;
        }
    }
}