namespace AcmeLanding.Services
{
    interface Interface
    {
    }
    public interface ISerialNumber
    {
        bool SerialNumberVali(int number);
    }
    public interface IAgeValidate
    {
        bool IsValid(int age);
    }
    public interface IDraw
    {
        bool WinnerOrNot(int number);
    }
}
