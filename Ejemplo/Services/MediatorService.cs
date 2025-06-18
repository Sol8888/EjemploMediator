namespace Ejemplo.Services
{
    public class MediatorService
    {
        public event Action<string>? OnMensaje;

        public void Enviar(string mensaje)
        {
            OnMensaje?.Invoke(mensaje);
        }
    }
}
