namespace Singleton.SingletonThreadSafe
{
    public class SingletonThreadSafe
    {

        private static SingletonThreadSafe _instance;
        // Aqui la diferencia es que se crea el object para retrasar la creacion
        private static readonly object _lock = new object();

        private SingletonThreadSafe()
        {

        }

        public static SingletonThreadSafe GetInstance()
        {
            // Utilizando doble comprobación de bloqueo (double-checked locking) para asegurar la concurrencia segura
            if (instance == null)
            {
                lock (lockObject) // Lock aseguarse que haya una seguridad de hilos. un solo hilo puede entrar a la vez
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}