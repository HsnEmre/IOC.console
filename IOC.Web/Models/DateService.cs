namespace IOC.Web.Models
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;


        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;


            _logger.LogWarning("DateService entry constructor");
        }


        public DateTime GetDateTime { get; } = DateTime.Now;//if use lambda write code this do not construct


    }
}
