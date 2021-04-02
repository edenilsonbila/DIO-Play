using DIO_Play.Classes;

namespace DIO_Play.Interfaces
{
    interface IMedia
    {
        void Play();

        void Pause();

        void Avancar(int tempo);

        void Retroceder(int tempo);
    }
}
