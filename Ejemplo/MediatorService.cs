namespace Ejemplo
{
    public class MediatorService
    {
        public event Action<string>? OnNotificar;

        public void Notificar(string mensaje)
        {
            OnNotificar?.Invoke(mensaje);
        }
    }
}
