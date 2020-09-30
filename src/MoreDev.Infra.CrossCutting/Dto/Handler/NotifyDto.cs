namespace MoreDev.Infra.CrossCutting.Dto.Handler
{
    public class NotifyDto
    {
        public string Mensage { get; set; }
        public NotifyDto(string mensage)
        {
            Mensage = mensage;
        }
    }
}
